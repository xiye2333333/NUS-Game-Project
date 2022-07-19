using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static int GlobalDay;
    public static int BossDay;
    public static int MonsterNum;
    public static int MonsterUpd;
    private GameObject Hero;
    private GameObject Boss;
    private static TimeManager tm;

    private GameObject DayText;
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
        Boss.SetActive((GlobalDay >= BossDay) ? true : false);
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
    }
}
