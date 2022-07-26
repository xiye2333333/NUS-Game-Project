using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
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
    public int day = 1;

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
        if (ifreleaseMonsters)
        {
            if (monsterReleaseNum < TimeManager.MonsterNum)
            {
                if (Time.time - timeStamp > monsterTriggerTime)
                {
                    releaseMonsters();
                    timeStamp = Time.time;
                    monsterReleaseNum++;
                }
            }
        }
    }

    void releaseMonsters()
    {
        int GlobalDay = TimeManager.GlobalDay;
        String MonsterType = "Prefab/Monster ";
        if (GlobalDay < 5)
        {
            MonsterType += "A";
        }
        else if (GlobalDay < 10)
        {
            MonsterType += "B";
        }
        else if (GlobalDay < 15)
        {
            MonsterType += "C";
        }
        else
        {
            MonsterType += "D";
        }

        GameObject Monster = Instantiate(Resources.Load(MonsterType) as GameObject);
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
            // for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
            // {
            //     if ((GameObject)GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i] != gameObject)
            //     {
            //         ((GameObject) (GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i]))
            //             .GetComponent<BoxCollider2D>().enabled = false;
            //     }
            // }
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
            for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
            {

                    ((GameObject) (GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i]))
                        .GetComponent<BoxCollider2D>().enabled = true;

            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(1))
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
            {
                if (GameObject.Find("Build Menu") != null)
                    GameObject.Find("Build Menu").SetActive(false);
                if (GameObject.Find("BuildButton") != null)
                    GameObject.Find("BuildButton").gameObject.SetActive(false);
                if (GameObject.Find("BagButton") != null)
                    GameObject.Find("BagButton").gameObject.SetActive(false);
                GameManager.getGM.SwitchToUpgrading();
                
                GameObject.Find("Canvas").transform.Find("PullDown").gameObject.SetActive(true);
                GameObject.Find("PullDown").GetComponent<PullDown>().TargetBuilding = gameObject;
            }
        }
    }
    public override void Culculate()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Money += TimeManager.MonsterNum * (60 + 20 * TimeManager.MonsterUpd - TimeManager.GlobalDay / 5 * 20);
    }
}