using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterBehavior : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        HP = 10;
        MaxHP = 10;
        Attack = 5;
        Defence = 1;
        Speed = 2.0f;
        Critical = 0f;
        Hero = GameObject.Find("Hero");
        freeze  = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0){
            Destroy(gameObject);
            Hero.GetComponent<HeroBehavior>().Wood += 2;
            Hero.GetComponent<HeroBehavior>().Stone += 2;
            Hero.GetComponent<HeroBehavior>().Money += 50;
        }
        FindDirection();
        if(!freeze){
           Move(); 
        }
        HpBarSlider.value = (float) HP / (MaxHP*1.0f);
        
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
        if (demage < Defence){
            return;
        }
        HP -= (demage - Defence);
    }
}
