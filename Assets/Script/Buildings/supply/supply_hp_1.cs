using System;
using System.Collections;
using System.Collections.Generic;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class supply_hp_1 : Building
// supply_hp_1: hp+20; money=80
// supply_hp_2: hp+40, money=200,wood=5
// supply_hp_3: hp+80, money=500,wood=20,iron=5
{
    public int hp;

    void Start()
    {
        level = 1;
        name = "HP Supply 1";
        hp = 50;
        Info = "HP Supply 1: hp+50";
    }
    
    void Update()
    {
        if (level == 2)
        {
            name = "HP Supply 2";
            hp = 100;
            Info = "HP Supply 2: hp+100";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpRecover2");
        }

        if (level == 3)
        {
            name = "HP Supply 3";
            hp = 200;
            Info = "HP Supply 3: hp+200";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpRecover3");
        }
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
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayRecover();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainHP(hp);
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
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 5;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade HP Supply 1?\n It needs money=200 and wood=5.";
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
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 5;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade HP Supply 2?\n It needs money=500, wood=20 and iron=5.";
            }
        }
    }

}