using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int GlobalDay = 1;
    private GameObject Hero;
    private static TimeManager tm;

    private GameObject DayText;
    private void Awake()
    {
        tm = this;
    }

    void Start()
    {
        DayText = GameObject.Find("DayText");
    }

    // Update is called once per frame
    void Update()
    {
        DayText.GetComponent<Text>().text = "Day: " + GlobalDay;
    }

    public static TimeManager getTM{
        get{
            return tm;
        }
    }
    public void TimePass(){
        GlobalDay++;
    }
}
