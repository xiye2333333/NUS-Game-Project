using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_hp_1 : Building
// statue_hp_1: hpCeil+10; money=300, wood=5
// statue_hp_2: hpCeil+20; money=700, wood=20, iron=10
// statue_hp_3: hpCeil+50; money=1500, wood=50, iron=20, gem=2
{
    public int hpCeil;

    void Start()
    {
        level = 1;
        name = "HP Statue 1";
        hpCeil = 10;
        Info = "HP Statue 1: hpCeil+10";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil += hpCeil;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().HP >=
            GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().HP =
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil;
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 2)
        {
            name = "HP Statue 2";
            hpCeil = 20;
            Info = "HP Statue 2: hpCeil+20";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpStatue2");
        }

        if (level == 3)
        {
            name = "HP Statue 3";
            hpCeil = 50;
            Info = "HP Statue 3: hpCeil+50";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpStatue3");
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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 700;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 10;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().hpCeil = 10;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade HP Statue 1?\n It needs money=700, wood=20 and iron=10.";
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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1500;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 50;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().gem = 2;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().hpCeil = 30;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade HP Statue 2?\n It needs money=1500, wood=50, iron=20 and gem=2.";
            }
        }
    }
    
}