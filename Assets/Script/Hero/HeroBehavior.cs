using System;
using System.Collections;
using System.Collections.Generic;
using Script.Skill;
using Script.Staff;
using Script.Staff.Armor;
using Script.Staff.Boot;
using Script.Staff.Helmet;
using Script.Staff.Shield;
using UnityEngine;
using UnityEngine.UI;

public class HeroBehavior : MonoBehaviour
{
    public int HP;

    public int MP;

    public int HPCeil;

    public int MPCeil;

    public int Attack;

    public int Defense;

    public int Money;

    public int Wood;

    public int Stone;

    public int Iron;

    public int Gem;

    public int Level;

    public float Speed = 0f;

    public Slider HpBarSlider;

    public Queue<GameObject> Monsters;

    public bool isFight;

    private bool freeze;

    private float mFightAt = 0f;

    public float roundTime = 0.5f;

    private int currentAttack = 0;

    private float timeSinceAttack = 0.0f;

    public Animator mAnimator;

    public bool death = false;

    private int loopCnt = 0;

    private GameObject StartCamp;

    private Vector3 StartPosition;

    private bool isBoss = false;

    public ArrayList EquipmentBag = new ArrayList();

    public ArrayList ItemBag = new ArrayList();

    public Weapon Weapon;

    public Armor Armor;

    public Boot Boot;

    public Helmet Helmet;

    public Shield Shield;

    private bool heroRound;

    public ArrayList BuildingList = new ArrayList();

    public float timer = 0f;

    public int MPrecover = 0;

    public Skill Skill;

    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        HPCeil = 100;
        MP = 0;
        MPCeil = 50;
        Attack = 5;
        Defense = 1;
        Wood = 0;
        Stone = 0;
        Iron = 0;
        Gem = 0;
        Money = 200;
        Level = 1;
        MPrecover = 5;

        // set the initial Hp to be full
        HpBarSlider.value = 1.0f;
        // initialize the monsters queue
        Monsters = new Queue<GameObject>();
        // deactivate the fight mode
        isFight = false;
        // deactivate the freeze (not move)
        freeze = false;
        // set the hero attack first
        heroRound = true;

        mFightAt = 0;
        roundTime = 0.8f;
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("Grounded", true);

        StartCamp = GameObject.Find("StartCamp");
        StartPosition.x = StartCamp.transform.position.x;
        StartPosition.y = this.transform.position.y;
        StartPosition.z = this.transform.position.z;
        

    }

    // Update is called once per frame
    void Update()
    {
        mFightAt += Time.deltaTime;
        if (!freeze)
        {
            Vector3 position = GetComponent<Transform>().position;
            position += Vector3.right * Speed * Time.smoothDeltaTime;
            GetComponent<Transform>().position = position;
        }

        GetComponent<SpriteRenderer>().sortingOrder = 1000;

        while (Monsters.Count > 0)
        {
            if (Monsters.Peek() == null)
            {
                Monsters.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (BossBehavior.isWin && Monsters.Count != 0)
            Monsters.Dequeue();

        if (Monsters.Count == 0)
        {
            EndFight();
        }

        #region Fight

        if (isFight)
        {
            mAnimator.SetInteger("AnimState", 0);
            if (mFightAt > roundTime)
            {
                #region HeroRound

                if (heroRound)
                {
                    currentAttack++;
                    if (currentAttack > 3)
                    {
                        currentAttack = 1;
                    }

                    if (mFightAt > 1.5f)
                    {
                        currentAttack = 1;
                    }

                    if (!isBoss)
                    {
                        if (MP == MPCeil && Skill != null)
                        {
                            MP = 0;
                            Skill.Use(Monsters.Peek(), false);
                        }
                        else
                        {
                            Monsters.Peek().GetComponent<MonsterBehavior>().isHit(Attack);
                            if (MP + MPrecover < MPCeil)
                            {
                                MP += MPrecover;
                            }
                            else if (MP + MPrecover > MPCeil && MP < MPCeil)
                            {
                                MP = MPCeil;
                            }
                        }
                    }
                    else
                    {
                        Monsters.Peek().GetComponent<BossBehavior>().isHit(Attack);
                    }

                    mAnimator.SetTrigger("Attack" + currentAttack);
                    GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayHeroHit();
                }

                #endregion

                #region MonsterRound

                else
                {
                    foreach (GameObject M in Monsters)
                    {
                        if (M != null){
                            if (!isBoss)
                            {
                                M.GetComponent<MonsterBehavior>().attack();
                                isHit(M.GetComponent<MonsterBehavior>().Attack);
                            }
                            else
                            {
                                M.GetComponent<BossBehavior>().attack();
                                isHit(M.GetComponent<BossBehavior>().Attack);
                            }
                        }
                    }
                }

                #endregion

                heroRound = !heroRound;

                if (HP <= 0)
                {
                    // Death();
                    EndFight();
                    death = true;
                    GameManager.getGM.SwitchToPause();
                }

                mFightAt = 0;
            }
        }

        #endregion

        else if (!isFight && !death)
        {
            mAnimator.SetInteger("AnimState", 1);
        }
        else if (death && TimeManager.loopCnt == 0)
        {
            if (timer == 0)
            {
                mAnimator.SetTrigger("Death");
                timer = Time.time;
            }

            //TimeManager.loopCnt++;
            if (Time.time - timer > 1.4f)
            {
                GameObject.Find("Canvas").transform.Find("LossPanel").gameObject.SetActive(true);
            }
        }

        HpBarSlider.value = (float) HP / (HPCeil * 1.0f);

        if (Input.GetKeyDown(KeyCode.M))
        {
            BackHome();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster")
        {
            if (other.gameObject.name == "Boss")
                isBoss = true;
            else
                isBoss = false;
            Monsters.Enqueue(other.gameObject);
            StartFight();
        }

        if (other.gameObject.tag == "EndCamp")
        {
            BackHome();
        }
    }

    public void BackHome()
    {
        this.transform.position = StartPosition;
        this.HP = HPCeil;
        //this.MP = MPCeil;
        //CameraBehavior.getCB.FollowHero();
        CameraBehavior.getCB.BackLeftHome();
        GameManager.getGM.SwitchToPause();
        TimeManager.getTM.TimePass();
    }

    void StartFight()
    {
        freeze = true;
        isFight = true;
    }

    void EndFight()
    {
        freeze = false;
        isFight = false;
        heroRound = true;
    }

    void isHit(int demage)
    {
        HP -= (int) Math.Round((double) demage * (1f - (double) Defense / ((double) Defense + 40f)));
        mAnimator.SetTrigger("hurt");
    }
}