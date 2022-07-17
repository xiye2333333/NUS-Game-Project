using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class hunted_house : Building
{
    public int attack = 5;
    public int defense = 10;
    public int hp = 5;
    public int mp = 10;
    public int award = 10;
    public int num = 1;
    public int day = 0;
    void Start()
    {
        name = "Hunted House";
        Hero = GameObject.Find("Hero");
        Info = "Hunt monster(maybe dangerous)";
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            day++;
            GameObject Monster = Instantiate(Resources.Load("Prefab/Monster A") as GameObject);
            Monster.transform.position = gameObject.transform.position;

            // int temp = GameObject.Find("Hero").GetComponent<HeroBehavior>().HP + hp;
            // if (temp > GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil)
            //     GameObject.Find("Hero").GetComponent<HeroBehavior>().HP =
            //         GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil;
            // else
            //     GameObject.Find("Hero").GetComponent<HeroBehavior>().HP = temp;
        }
    }

    void AfterDay()
    {
        if (day % 5 == 0)
        {
            num++;
        }
        attack++;
        defense++;
        hp++;
        award++;
        if (day % 20 == 0)
        {
            attack *= 2;
            defense *= 2;
            hp *= 2;
            award *= 2;
            num = 1;
        }
        day++;
    }
    
}