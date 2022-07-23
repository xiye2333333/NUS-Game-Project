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
        name = "Goddess Statue - 1";
        hpCeil = 20;
        Info = "Goddess Statue - 1\nIncrease HP ceiling by 20.\nGoddess blesses you.";
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
            name = "Goddess Statue - 2";
            hpCeil = 50;
            Info = "Goddess Statue - 2\nIncrease HP ceiling by 50.\nGoddess blesses you.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpStatue2");
        }

        if (level == 3)
        {
            name = "Goddess Statue - 3(max)";
            hpCeil = 100;
            Info = "Goddess Statue - 3(max)\nIncrease HP ceiling by 100.\nGoddess blesses you.";
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
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().hpCeil = 30;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade\nGoddess Statue - 1?\nIt needs 700 gold coins, 20 woods and 10 irons.";
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
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().hpCeil = 50;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Are you sure to upgrade\nGoddess Statue - 2?\nIt needs 1500 gold coins, 50 woods, 20 irons and 2 gems.";
            }
        }
    }
    
}