using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class equip_attack_1 : Building
{
    public int attack = 2;

    void Start()
    {
        level = 11;
        name = "Attack Equipment 1";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack += attack;
        attack = 2;
        money = 400;
        wood = 20;
        stone = 20;
        iron = 0;
        gem = 0;
        level++;//2
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Upgrade()
    {
        if (CanUpgrade())
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack += attack;
            Purchase();
            attack = 4;
            money = 1000;
            wood = 50;
            stone = 50;
            iron = 10;
            gem = 0;
            name = "Attack Equipment "+ level;
            level++;//3//4
        }
    }
}