using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_hp_1 : Building
{
    public int hpCeil = 10;

    void Start()
    {
        level = 1;
        name = "HP Statue 1";
        Debug.Log(1);
        GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil += hpCeil;
        hpCeil = 10;
        money = 700;
        wood = 20;
        stone = 0;
        iron = 10;
        gem = 0;
        level++;//2
    }

    // Update is called once per frame
    void Update()
    {
    }


    // void Upgrade()
    // {
    //     if (CanUpgrade())
    //     {
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil += hpCeil;
    //         Purchase();
    //         hpCeil = 30;
    //         money = 1500;
    //         wood = 50;
    //         stone = 0;
    //         iron = 20;
    //         gem = 2;
    //         name = "HP Statue "+ level;
    //         level++;//3//4
    //         
    //     }
    // }
}