using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_attack_1 : Building
// statue_attack_1: attack+2; money=150, wood=5
// statue_attack_2: attack+4; money=400, wood=20, stone=20
// statue_attack_3: attack+8; money=1000, wood=50, stone=50, iron=10
{
    public int attack;

    void Start()
    {
        level = 1;
        name = "Knight Statue - 1";
        attack = 2;
        Info = "Knight Statue - 1\nIncrease attack by 2.\nKnight gives you power.";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack += attack;
    }

    void Update()
    {
        if (level == 2)
        {
            name = "Knight Statue - 2";
            attack = 4;
            Info = "Knight Statue - 2\nIncrease attack by 4.\nKnight gives you power.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("attack2");
        }

        if (level == 3)
        {
            name = "Knight Statue - 3(max)";
            attack = 8;
            Info = "Knight Statue - 3(max)\nIncrease attack by 8.\nKnight gives you power.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("attack3");
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
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 500;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 35;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 35;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().attack = 2;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nKnight Statue - 1?\nIt needs 500 gold coins, 35 woods and 35 stones.";
                }
            }

            if (level == 2)
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
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1500;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 100;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 100;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 30;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().attack = 4;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nKnight Statue - 2?\nIt needs 1500 gold coins, 100 woods, 100 stones and 30 irons.";
                }
            }
        } else if (Input.GetMouseButtonUp(1))
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
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack -= attack;
    }
    
    
}