using System;
using System.Collections;
using System.Collections.Generic;
using Script.UI;
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
        name = "Quarry - 1";
        addStone = 6;
        Info = "Quarry - 1\nGet 6 stones.\nIt regenerates every day.";
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 3)
        {
            name = "Quarry - 2(max)";
            addStone = 15;
            Info = "Quarry - 2(max)\nGet 15 stones.\nIt regenerates every day.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("stone3");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone += addStone;
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayWood();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainStone(addStone);
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
                    "Are you sure to upgrade\nQuarry - 1?\nIt needs 1000 gold coins, 50 woods and 15 irons.";
            }
        }
    }
}