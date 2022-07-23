using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class hunted_house : Building
{
    public float monsterTriggerTime = 0.6f;
    public float offsetX;
    public float offsetY;

    public float randomMonsterOffset;

    private float timeStamp;
    private bool ifreleaseMonsters;
    private int monsterReleaseNum;

    void Start()
    {
        name = "Monster House";
        Info = "Monster House\nHunt monsters for money.\nIt is also getting stronger.";

        randomMonsterOffset = 0.7f;
        offsetX = 0.5f;
        offsetY = 0.5f;
        timeStamp = Time.time;
        ifreleaseMonsters = false;
        monsterReleaseNum = 0;
    }
    
    void Update()
    {
        if(ifreleaseMonsters){
            if(monsterReleaseNum < TimeManager.MonsterNum){
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
        //p.x += Random.value * (2*randomMonsterOffset) - randomMonsterOffset;
        p.x += offsetX;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            ifreleaseMonsters = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            ifreleaseMonsters = false;
            monsterReleaseNum = 0;
        }
    }
}