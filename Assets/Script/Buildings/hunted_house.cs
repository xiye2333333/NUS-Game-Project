using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class hunted_house : Building
{
    public int monsterNum = 2;
    public float monsterTriggerTime = 0.6f;
    public float offsetY;

    public float randomMonsterOffset;

    private float timeStamp;
    private bool ifreleaseMonsters;
    private int monsterReleaseNum;

    void Start()
    {
        name = "Hunted House";
        Info = "Hunt monsters for money. May be dangerous.";

        randomMonsterOffset = 0.7f;
        offsetY = 0.5f;
        timeStamp = Time.time;
        ifreleaseMonsters = false;
        monsterReleaseNum = 0;
    }
    
    void Update()
    {
        if(ifreleaseMonsters){
            if(monsterReleaseNum < monsterNum){
                if(Time.time - timeStamp > monsterTriggerTime){
                    releaseMonsters();
                    timeStamp = Time.time;
                    monsterReleaseNum++;
                }
            }
            
        }
    }

    void releaseMonsters(){
        GameObject Monster = Instantiate(Resources.Load("Prefab/Monster A") as GameObject);
        Vector3 p = gameObject.transform.position;
        p.x += Random.value * (2*randomMonsterOffset) - randomMonsterOffset;
        p.y = offsetY;
        Monster.transform.position = p;

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            ifreleaseMonsters = true;
            
        }
    }

}