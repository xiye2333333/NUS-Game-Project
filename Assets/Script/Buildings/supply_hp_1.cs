using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class supply_hp_1 : Building
{
    public int hp = 20;

    void Start()
    {
        level = 1;
        name = "HP Supply 1";
        hp = 40;
        money = 200;
        wood = 5;
        stone = 0;
        iron = 0;
        gem = 0;
        level++;//2
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            int temp = GameObject.Find("Hero").GetComponent<HeroBehavior>().HP + hp;
            if (temp > GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HP =
                    GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil;
            else
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HP = temp;
        }
    }
    
    void Upgrade()
    {
        if (CanUpgrade())
        {
            Purchase();
            hp = 80;
            money = 500;
            wood = 20;
            stone = 0;
            iron = 50;
            gem = 0;
            name = "HP Supply "+ level;
            level++;//3//4
        }
    }
}