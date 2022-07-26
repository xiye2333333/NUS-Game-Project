using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class statue_mp_1 : Building
// statue_mp_1: mpCeil-1; money=150, stone=5
// statue_mp_2: hpCeil-2; money=1000, stone=20, iron=10
// statue_mp_3: hpCeil-3; money=2500, stone=50, iron=20, gem=2
{
    public int mpCeil;

    void Start()
    {
        level = 1;
        name = "Cross Statue - 1";
        mpCeil = -5;
        Info = "Cross Statue - 1\nDecrease MP ceiling by 5.\nReward for piety.";
        GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil += mpCeil;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil < 0)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil = 0;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().MP >=
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MP =
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil;
    }

    void Update()
    {
        if (level == 2)
        {
            name = "Cross Statue - 2";
            mpCeil = -10;
            Info = "Cross Statue - 2\nDecrease MP ceiling by 10.\nReward for piety.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("MpStatue2");
        }

        if (level == 3)
        {
            name = "Cross Statue - 3(max)";
            mpCeil = -15;
            Info = "Cross Statue - 3(max)\nDecrease MP ceiling by 15.\nReward for piety.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("MpStatue3");
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
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
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1000;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 10;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().mpCeil = -5;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nCross Statue - 1?\nIt needs 1000 gold coins, 20 woods and 10 irons.";
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
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 2500;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 50;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().gem = 2;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().mpCeil = -5;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nCross Statue - 2?\nIt needs 2500 gold coins, 50 woods, 20 irons and 2 gems.";
                }
            }
        } else if (Input.GetMouseButtonUp(1))
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
                
                GameObject.Find("Canvas").transform.Find("PullDown").gameObject.SetActive(true);
                GameObject.Find("PullDown").GetComponent<PullDown>().TargetBuilding = gameObject;
            }
        }
    }
}