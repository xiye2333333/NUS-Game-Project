using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static int GlobalDay;
    public static int BossDay;
    public static int loopCnt;
    public static int MonsterNum;
    public static int MonsterUpd;
    private GameObject Hero;
    private GameObject Boss;
    private static TimeManager tm;

    private GameObject DayText;
    public GameObject SwitchDay;
    private void Awake()
    {
        tm = this;
    }

    void Start()
    {
        DayText = GameObject.Find("DayText");
        Boss = GameObject.Find("Boss");
        GlobalDay = 1;
        BossDay = 10;
        MonsterNum = 1;
        MonsterUpd = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DayText.GetComponent<Text>().text = "Day: " + GlobalDay;
        if (!BossBehavior.isWin){
            BossBehavior.visiblity = (GlobalDay % BossDay == 0) ? true : false;
            Boss.SetActive(BossBehavior.visiblity);
        }
        if (BossBehavior.visiblity)
        {
            //Debug.Log(123);
            for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
            {
                //Debug.Log(111);
                ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
        {
            for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
            {
                ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }

    public static TimeManager getTM{
        get{
            return tm;
        }
    }

    public void TimePass(){
        GlobalDay++;
        if (GlobalDay % 5 == 0)
            MonsterNum++;
        MonsterUpd = GlobalDay / 2;
        SwitchDay.SetActive(true);
        GameObject DaySwitchText = GameObject.Find("DaySwitchText").gameObject;
        DaySwitchText.GetComponent<Text>().text = "Day: " + GlobalDay;
        
        if (GlobalDay % 1 == 0)// suppose to be 5
        {//Assets/Resources/Prefab/Store.prefab
            // GameObject Store = Instantiate(Resources.Load("Prefab/Store") as GameObject);
            GameObject StoreManager = GameObject.Find("StoreManager");
            StoreManager.transform.Find("Store").gameObject.SetActive(true);
            
            Vector3 v = new Vector3(-26.7f, 0.62f, 0);
            StoreManager.transform.Find("Store").position = v;
        }
    }
}
