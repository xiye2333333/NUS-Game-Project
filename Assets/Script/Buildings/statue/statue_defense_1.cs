using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_defense_1 : Building
// statue_defense_1: defense+2; money=150, stone=5
// statue_defense_2: defense+4; money=400, wood=20, stone=20
// statue_defense_3: defense+8; money=1000, wood=50, stone=50, iron=10
{
    public int defense;

    void Start()
    {
        level = 1;
        name = "Shield Statue - 1";
        defense = 2;
        Info = "Shield Statue - 1\nIncrease defense by 2.\nDivine shield gives you power.";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Defense += defense;
    }

    void Update()
    {
        if (level == 2)
        {
            name = "Shield Statue - 2";
            defense = 4;
            Info = "Shield Statue - 2\nIncrease defense by 4.\nDivine shield gives you power.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("defense2");
        }

        if (level == 3)
        {
            name = "Shield Statue - 3(max)";
            defense = 8;
            Info = "Shield Statue - 3()max)\nIncrease defense by 8.\nDivine shield gives you power.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("defense3");
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
            if (level == 1)
            {
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                    GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
                {
                    if (GameObject.Find("Build Menu") != null)
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
                    // for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
                    // {
                    //     if (((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).name != "Hunter(Clone)")
                    //     ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
                    // }
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 400;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().defense = 2;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nShield Statue - 1?\nIt needs 400 gold coins, 20 woods and 20 stones.";
                }
            }

            if (level == 2)
            {
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                    GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
                {
                    if (GameObject.Find("Build Menu") != null)
                        GameObject.Find("Build Menu").SetActive(false);
                    if (GameObject.Find("BuildButton") != null)
                        GameObject.Find("BuildButton").gameObject.SetActive(false);
                    if (GameObject.Find("BagButton") != null)
                        GameObject.Find("BagButton").gameObject.SetActive(false);
                    GameManager.getGM.SwitchToUpgrading();

                    GameObject.Find("Canvas").transform.Find("Upgrade").gameObject.SetActive(true);
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().building = gameObject;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1000;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 50;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 50;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 10;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().defense = 4;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nShield Statue - 2?\nIt needs 1000 gold coins, 50 woods, 50 stones and 10 irons.";
                }
            }
        }else if (Input.GetMouseButtonUp(1))
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
            {
                if (GameObject.Find("Build Menu") != null)
                    GameObject.Find("Build Menu").SetActive(false);
                if (GameObject.Find("BuildButton") != null)
                    GameObject.Find("BuildButton").gameObject.SetActive(false);
                if (GameObject.Find("BagButton") != null)
                    GameObject.Find("BagButton").gameObject.SetActive(false);
                GameManager.getGM.SwitchToUpgrading();
                
                GameObject.Find("Canvas").transform.Find("PullDown").gameObject.SetActive(true);
                GameObject.Find("PullDown").GetComponent<PullDown>().TargetBuilding = gameObject;
            }
        }
    }
    public override void PullDown()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Defense -= defense;
    }
}