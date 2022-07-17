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
    void Start()
    {
        Hero = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public static TimeManager getTM{
        get{
            return tm;
        }
    }
    public void TimePass(){
        GlobalDay++;
    }
    public string TimeMassege(){
        return "Day: " + GlobalDay;
    }
}
