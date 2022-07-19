using System.Collections;
using System.Collections.Generic;
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

    public float Speed = 0.1f;

    public Slider HpBarSlider;

    public Queue<GameObject> Monsters;

    public bool isFight;

    private bool freeze;

    private float mFightAt = 0f;

    public float roundTime = 1f;
    
    private int currentAttack = 0;

    private float timeSinceAttack = 0.0f;

    private Animator mAnimator;

    private bool death = false;

    private int loopCnt = 0;

    private GameObject StartCamp;

    private Vector3 StartPosition;

    private bool isBoss = false;
    
    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        HPCeil = 100;
        MP = 50;
        MPCeil = 50;
        Attack = 5;
        Defense = 1;
        Wood = 80;
        Stone = 80;
        Iron = 50;
        Gem = 5;
        Level = 3;

        // set the initial Hp to be full
        HpBarSlider.value = 1.0f;
        // initialize the monsters queue
        Monsters = new Queue<GameObject>();
        // deactivate the fight mode
        isFight = false;
        // deactivate the freeze (not move)
        freeze = false;

        mFightAt = 0;
        roundTime = 1f;
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("Grounded",true);

        StartCamp = GameObject.Find("StartCamp");
        StartPosition.x = StartCamp.transform.position.x;
        StartPosition.y = this.transform.position.y;
        StartPosition.z = this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        mFightAt+= Time.deltaTime;
        if(!freeze){
            Vector3 position = GetComponent<Transform>().position;
            position += Vector3.right * Speed * Time.smoothDeltaTime;
            GetComponent<Transform>().position = position;
        }
        GetComponent<SpriteRenderer>().sortingOrder = 1000;
        
        while(Monsters.Count > 0){
            if (Monsters.Peek() == null){
                Monsters.Dequeue();
            }else{
                break;
            }
        }
        if (Monsters.Count == 0){
            EndFight();
        }
        #region Fight
        if (isFight){           
            mAnimator.SetInteger("AnimState", 0);
            if (mFightAt > roundTime)
            {
                currentAttack++;
                if (currentAttack > 3)
                    currentAttack = 1;

                if (mFightAt > 1.5f)
                    currentAttack = 1;
                #region HeroRound
                if (!isBoss)
                    Monsters.Peek().GetComponent<MonsterBehavior>().isHit(Attack);
                else
                    Monsters.Peek().GetComponent<BossBehavior>().isHit(Attack);
                mAnimator.SetTrigger("Attack"+currentAttack);
                #endregion

                #region MonsterRound
                foreach( GameObject M in Monsters )
                {
                    if(M != null)
                        if (!isBoss)
                            isHit(M.GetComponent<MonsterBehavior>().Attack);
                        else
                            isHit(M.GetComponent<BossBehavior>().Attack);
                }
                #endregion

                if (HP <= 0)
                {
                    // Death();
                    EndFight();
                    death = true;
                }
                mFightAt = 0;
            }
            
        }
        #endregion

        else if (!isFight && !death)
        {
            mAnimator.SetInteger("AnimState", 1);
        }else if (death && loopCnt == 0)
        {
            mAnimator.SetTrigger("Death");
            loopCnt++;
            GameManager.getGM.SwitchToPause();
        }
        HpBarSlider.value = (float) HP / (HPCeil*1.0f);

        if (Input.GetKeyDown(KeyCode.H)){
            BackHome();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Monster"){
            if (other.gameObject.name == "Boss")
                isBoss = true;
            else
                isBoss = false;
            Monsters.Enqueue(other.gameObject);
            StartFight();
        }
        if (other.gameObject.tag == "EndCamp"){
            BackHome();
        }
    }

    public void BackHome(){
        this.transform.position = StartPosition;
        this.HP = HPCeil;
        this.MP = MPCeil;
        //CameraBehavior.getCB.FollowHero();
        CameraBehavior.getCB.BackLeftHome();
        GameManager.getGM.SwitchToPause();
        TimeManager.getTM.TimePass();
    }
    void StartFight(){
        freeze = true;
        isFight = true;
    }

    void EndFight(){
        freeze = false;
        isFight = false;
    }

    void isHit(int demage){
        if (demage < Defense){
            return;
        }
        HP -= (demage - Defense);
    }

}
