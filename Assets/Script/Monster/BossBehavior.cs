using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class BossBehavior : MonoBehaviour
{
    public GameObject Hero;

    public int HP;

    public int MaxHP;

    public int Attack;

    public int Defence;

    public float Speed;

    public float Critical;

    public Slider HpBarSlider;

    public int Direction;

    public bool freeze;

    private Animator mAnimator;

    public static bool isWin;

    public static bool visiblity;

    public float timer = 0f;

    Vector3 StartPoint;
    // Start is called before the first frame update
    void Start()
    {
        HP = 400;
        MaxHP = 400;
        Attack = 120;
        Defence = 70;
        Speed = 2.0f;
        Critical = 0f;
        HpBarSlider.value = 1.0f;
        Hero = GameObject.Find("Hero");
        freeze  = false;
        isWin = false;
        visiblity = false;
        StartPoint = transform.position;
        mAnimator = GetComponent<Animator>();
        //mAnimator.SetBool("Grounded",true);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectWithTag("BossHPText").GetComponent<Text>().text = "Boss HP " + HP + "/" + MaxHP;
        if (HP <= 0){
            
            if (timer == 0)
            {
                mAnimator.SetTrigger("Death");
                isWin = true;
                GameManager.getGM.SwitchToPause();
                timer = Time.time;
            }     
            if (Time.time - timer > 1.4f)
            {
                Destroy(gameObject);
                GameObject.Find("Canvas").transform.Find("WinPanel").gameObject.SetActive(true);
            }
            //Hero.GetComponent<HeroBehavior>().Money += 50000;
        }
        FindDirection();
        if(!freeze){
            //mAnimator.SetTrigger("Walk");
            Move(); 
        }
        else{
            //mAnimator.SetTrigger("Attack");
        }
        HpBarSlider.value = (float) HP / (MaxHP * 1.0f);
    }

    public void Reset(){
        HP = MaxHP;
        transform.position = StartPoint;
        DeFreeze();
    }

    void FindDirection(){
        float d = Hero.transform.position.x - transform.position.x;
        if (d > 0){
            Direction =  1;
        }else{
            Direction = -1;
        }
    }

    void Move(){
        mAnimator.SetBool("Walk",true);
        Vector3 position = GetComponent<Transform>().position;
        position.x += Direction * Speed * Time.smoothDeltaTime;
        GetComponent<Transform>().position = position;
    }

    public void Freeze(){
        freeze = true;
    }
    public void DeFreeze(){
        freeze = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Hero"){
            Freeze();
        }
    }
    
    public void isHit(int demage){
        HP -= (int)Math.Round((double)demage * (1f - (double)Defence / ((double)Defence + 40f)));
        mAnimator.SetTrigger("Hurt");
    }
    
    public void attack()
    {
        mAnimator.SetTrigger("Attack");
        mAnimator.SetBool("Walk",false);
        GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayBossHit();
    }
}