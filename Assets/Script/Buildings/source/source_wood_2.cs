using System;
using System.Collections;
using System.Collections.Generic;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class source_wood_2 : Building
// source_wood_1: wood+3; money=350, stone=20
// source_wood_2: wood+6; money=1000, stone=50, iron=15
{
    public int addWood;

    void Start()
    {
        level = 2;
        name = "Logging Camp - 1";
        addWood = 6;
        Info = "Logging Camp - 1\nGet 6 pieces of wood.\nIt regenerates every day.";
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 3)
        {
            name = "Logging Camp - 2(max)";
            addWood = 15;
            Info = "Logging Camp - 2(max)\nGet 15 pieces of wood.\nIt regenerates every day.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wood3");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood += addWood;
            // Debug.Log(GameObject.Find("AudioEffect").GetComponent<AudioManager>().AudioSound);
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayWood();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainWood(addWood);
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
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 50;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 15;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                GameObject.Find("UpgradeText").GetComponent<Text>().text =
                    "Are you sure to upgrade\nLogging Camp - 1?\nIt needs 1000 gold coins, 50 stones and 15 irons.";
            }
        }
    }
}