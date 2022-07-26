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
        addWood = 20;
        Info = "Logging Camp - 1\nGet 20 pieces of wood.\nIt regenerates every day.";
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 3)
        {
            name = "Logging Camp - 2(max)";
            addWood = 100;
            Info = "Logging Camp - 2(max)\nGet 100 pieces of wood.\nIt regenerates every day.";
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

    private void OnMouseUp()
    {
        if (level == 2)
        {
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running || GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
            {
                if(GameObject.Find("Build Menu") != null)
                    GameObject.Find("Build Menu").SetActive(false);
                // if (GameObject.Find("MerchantSay") != null)
                //     GameObject.Find("MerchantSay").gameObject.SetActive(false);
                if (GameObject.Find("BuildButton") != null)
                    GameObject.Find("BuildButton").gameObject.SetActive(false);
                if (GameObject.Find("BagButton") != null)
                    GameObject.Find("BagButton").gameObject.SetActive(false);
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