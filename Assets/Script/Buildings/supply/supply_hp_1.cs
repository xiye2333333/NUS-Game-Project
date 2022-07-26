using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Script.BuildingSystem;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class supply_hp_1 : Building
// supply_hp_1: hp+20; money=80
// supply_hp_2: hp+40, money=200,wood=5
// supply_hp_3: hp+80, money=500,wood=20,iron=5
{
    public int hp;

    void Start()
    {
        level = 1;
        name = "Treatment Station - 1";
        hp = 50;
        Info = "Treatment Station - 1\nHeal yourself by 50HP.\nBy eating, it seems.";
    }

    void Update()
    {
        if (level == 2)
        {
            name = "Treatment Station - 2";
            hp = 100;
            Info = "Treatment Station - 2\nHeal yourself by 100HP.\nBy eating, it seems.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpRecover2");
        }

        if (level == 3)
        {
            name = "Treatment Station - 3(max)";
            hp = 200;
            Info = "Treatment Station - 3(max)\nHeal yourself by 200HP.\nBy eating, it seems.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("HpRecover3");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            int temp = GameObject.Find("Hero").GetComponent<HeroBehavior>().HP + hp;
            if (temp > GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HP =
                    GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil;
            else
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HP = temp;
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayRecover();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainHP(hp);
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
                    //         ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
                    // }
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 200;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 5;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade Treatment Station - 1?\nIt needs 200 gold coins and 5 woods.";
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
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 500;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 5;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade Treatment Station - 2?\nIt needs 500 gold coins, 20 woods and 5 irons.";
                }
            }
        }
        else if (Input.GetMouseButtonUp(1))
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