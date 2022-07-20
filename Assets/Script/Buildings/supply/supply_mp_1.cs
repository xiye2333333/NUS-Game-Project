using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class supply_mp_1 : Building
// supply_mp_1: mp+1; money=80
// supply_mp_2: mp+2, money=200,stone=5
// supply_mp_3: mp+3, money=500,stone=20,iron=5
{
    public int mp;

    void Start()
    {
        level = 1;
        name = "MP Supply 1";
        mp = 1;
        Info = "MP Supply 1: mp+1";
    }
    
    void Update()
    {
        if (level == 2)
        {
            name = "MP Supply 2";
            mp = 2;
            Info = "MP Supply 2: mp+2";
        }

        if (level == 3)
        {
            name = "MP Supply 3";
            mp = 3;
            Info = "MP Supply 3: mp+3";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            int temp = GameObject.Find("Hero").GetComponent<HeroBehavior>().MP + mp;
            if (temp > GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MP =
                    GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil;
            else
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MP = temp;
        }
    }

    private void OnMouseDown()
    {
        if (level == 1)
        {
            if (!BuildMenu.BuildingFlag && GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Bagging)
            {
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
                    GameManager.getGM.SwitchToUpgrading();

                GameObject.Find("Canvas").transform.Find("Upgrade").gameObject.SetActive(true);
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().building = gameObject;

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 200;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 5;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade MP Supply 1?\n It needs money=200 and stone=5.";
            }
        }

        if (level == 2)
        {
            if (!BuildMenu.BuildingFlag && GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Bagging)
            {
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
                    GameManager.getGM.SwitchToUpgrading();

                GameObject.Find("Canvas").transform.Find("Upgrade").gameObject.SetActive(true);
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().building = gameObject;

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 500;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 5;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade MP Supply 2?\n It needs money=500, stone=20 and iron=5.";
            }
        }
    }

}