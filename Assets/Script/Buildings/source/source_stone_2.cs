using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class source_stone_2 : Building
// source_stone_1: stone+3; money=350, wood=20
// source_stone_2: stone+6; money=1000, wood=50, iron=15
{
    public int addStone;

    void Start()
    {
        level = 2;
        name = "Stone Source 1";
        addStone = 3;
        Info = "Stone Source 1: stone+3";
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 3)
        {
            name = "Stone Source 2";
            addStone = 6;
            Info = "Stone Source 2: stone+6";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("stone3");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone += addStone;
        }
    }

    private void OnMouseDown()
    {
        if (level == 2)
        {
            if (!BuildMenu.BuildingFlag && GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Bagging)
            {
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
                    GameManager.getGM.SwitchToUpgrading();

                GameObject.Find("Canvas").transform.Find("Upgrade").gameObject.SetActive(true);
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().building = gameObject;

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1000;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 50;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 15;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("UpgradeText").GetComponent<Text>().text =
                    "Are you sure to upgrade Stone Source 1?\n It needs money=1000, wood=50 and iron=15.";
            }
        }
    }
}