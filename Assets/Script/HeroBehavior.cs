using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroBehavior : MonoBehaviour
{
    public int HP;

    public int MaxHP;

    public int MP;

    public int MaxMP;

    public int Attack;

    public int Defence;

    public int Money = 100;

    public float Speed = 0.1f;

    public Slider HpBarSlider;

    public Queue<GameObject> Monsters;

    public bool isFight;

    private bool freeze;

    private float mFightAt = 0f;

    public float roundTime = 1f;
    private GameObject StartCamp;
    private Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        MaxHP = 100;
        MP = 50;
        MaxMP = 50;
        Attack = 5;
        Defence = 1;
        
        // set the initial Hp to be full
        HpBarSlider.value = 1.0f;
        // initialize the monsters queue
        Monsters = new Queue<GameObject>();
        // deactivate the fight mode
        isFight = false;
        // deactivate the freeze (not move)
        freeze = false;

        mFightAt = Time.time;
        roundTime = 1f;
        StartCamp = GameObject.Find("StartCamp");
        StartPosition.x = StartCamp.transform.position.x;
        StartPosition.y = this.transform.position.y;
        StartPosition.z = this.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
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
            if ((Time.time - mFightAt) > roundTime){

                #region HeroRound
                Monsters.Peek().GetComponent<MonsterBehavior>().isHit(Attack);
                #endregion

                #region MonsterRound
                foreach( GameObject M in Monsters )
                {
                    if(M != null)
                        isHit(M.GetComponent<MonsterBehavior>().Attack);
                }
                #endregion

                mFightAt = Time.time;
            }
            
        }
        #endregion

        HpBarSlider.value = (float) HP / (MaxHP*1.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster"){
            Monsters.Enqueue(other.gameObject);
            StartFight();
        }
        if (other.gameObject.tag == "EndCamp"){
            this.transform.position = StartPosition;
            this.HP = MaxHP;
            this.MP = MaxMP;
            TimeManager.getTM.TimePass();
        }
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
        if (demage < Defence){
            return;
        }
        HP -= (demage - Defence);
    }

}
