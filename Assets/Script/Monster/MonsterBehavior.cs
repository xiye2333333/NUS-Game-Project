using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Script.UI;

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

    public int Wood;
    public int Stone;
    public int Iron;
    public int Gem;
    public int Money;
    public float dieTime;

    private int flag = 0;

    public int Upd;

    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        Upd = TimeManager.MonsterUpd;
        HP = 15 + 2 * Upd;
        MaxHP = 15 + 2 * Upd;
        Attack = 15 + 2 * Upd;
        Defence = 2 + 2 * Upd;
        Speed = 2.0f;
        Critical = 0f;
        Hero = GameObject.Find("Hero");
        freeze = false;
        Wood = 2 + Upd;
        Stone = 2 + Upd;
        Iron = 1 + Upd / 2;
        Gem = 1;

        Money = 50 + 20 * Upd;

        dieTime = 0.5f;

        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("run");
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            mAnimator.SetTrigger("death");
            Invoke("killMonster", dieTime);
        }

        FindDirection();
        if (!freeze)
        {
            Move();
        }

        HpBarSlider.value = (float) HP / (MaxHP * 1.0f);
        if (Hero.GetComponent<HeroBehavior>().death)
            Invoke("killMonster", dieTime);
    }

    void FindDirection()
    {
        float d = Hero.transform.position.x - transform.position.x;
        if (d > 0)
        {
            Direction = 1;
        }
        else
        {
            Direction = -1;
        }
    }

    void Move()
    {
        Vector3 position = GetComponent<Transform>().position;
        position.x += Direction * Speed * Time.smoothDeltaTime;
        GetComponent<Transform>().position = position;
    }

    public void Freeze()
    {
        freeze = true;
    }

    public void DeFreeze()
    {
        freeze = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hero")
        {
            Freeze();
        }
    }

    public void isHit(int demage)
    {
        mAnimator.SetTrigger("takehit");
        HP -= (int) Math.Round((double) demage * (1f - (double) Defence / ((double) Defence + 40f)));
        Vector3 position = GetComponent<Transform>().position;
        position.z = -2.0f;
        GetComponent<Transform>().position = position;
    }

    public void attack()
    {
        mAnimator.SetTrigger("attack");
        GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayMonsterHit();
    }

    void killMonster()
    {
        if (flag == 0)
        {
            int Drop = UnityEngine.Random.Range(1, 101);
            Hero.GetComponent<HeroBehavior>().Money += Money;
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainMoney(Money);
            if (Drop > 0 && Drop <= 32)
            {
                Hero.GetComponent<HeroBehavior>().Wood += Wood;
                DropWood(0.2f);
            }
            else if (Drop > 32 && Drop <= 64)
            {
                Hero.GetComponent<HeroBehavior>().Stone += Stone;
                DropStone(0.2f);
            }
            else if (Drop > 64 && Drop <= 84)
            {
                Hero.GetComponent<HeroBehavior>().Wood += Wood;
                Hero.GetComponent<HeroBehavior>().Stone += Stone;
                DropWood(0.2f);
                DropStone(0.4f);
            }
            else if (Drop > 84 && Drop <= 89)
            {
                Hero.GetComponent<HeroBehavior>().Iron += Iron;
                DropIron(0.2f);
            }
            else if (Drop > 89 && Drop <= 90)
            {
                Hero.GetComponent<HeroBehavior>().Gem += Gem;
                DropGem(0.2f);
            }

            flag = 1;
        }

        // Debug.Log(Money);
        Destroy(gameObject);
    }

    public void DropMoney(float time)
    {
        HeroCanvas heroCanvas = GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>();
        heroCanvas.Money = Money;
        heroCanvas.HelpInvoke("ObtainMoney2", time);
    }

    public void DropWood(float time)
    {
        HeroCanvas heroCanvas = GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>();
        heroCanvas.Wood = Wood;
        heroCanvas.HelpInvoke("ObtainWood2", time);
    }
    
    

    public void DropStone(float time)
    {
        HeroCanvas heroCanvas = GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>();
        heroCanvas.Stone = Stone;
        heroCanvas.HelpInvoke("ObtainStone2", time);
    }

    public void DropIron(float time)
    {
        HeroCanvas heroCanvas = GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>();
        heroCanvas.Iron = Iron;
        heroCanvas.HelpInvoke("ObtainIron2", time);
    }

    public void DropGem(float time)
    {
        HeroCanvas heroCanvas = GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>();
        heroCanvas.Gem = Gem;
        heroCanvas.HelpInvoke("ObtainGem2", time);
    }
}