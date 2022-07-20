using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_mp_1 : Building
// statue_mp_1: mpCeil-1; money=500, stone=5
// statue_mp_2: hpCeil-2; money=1000, stone=20, iron=10
// statue_mp_3: hpCeil-3; money=2500, stone=50, iron=20, gem=2
{
    public int mpCeil;

    void Start()
    {
        level = 1;
        name = "MP Statue 1";
        mpCeil = -1;
        Info = "MP Statue 1: mpCeil-1";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil += mpCeil;
    }
    
    void Update()
    {
        if (level == 2)
        {
            name = "MP Statue 2";
            mpCeil = -2;
            Info = "MP Statue 2: mpCeil-2";
        }

        if (level == 3)
        {
            name = "MP Statue 3";
            mpCeil = -3;
            Info = "MP Statue 3: mpCeil-3";
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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1000;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 10;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().mpCeil = -1;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade MP Statue 1?\n It needs money=1000, wood=20 and iron=10.";
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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 2500;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 50;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 20;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().gem = 2;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().mpCeil = -1;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade MP Statue 2?\n It needs money=2500, wood=50, iron=20 and gem=2.";
            }
        }
    }
    
}