using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class supply_mp_1 : Building
// supply_mp_1: mp+1; money=80
// supply_mp_2: mp+2, money=200,stone=5
// supply_mp_3: mp+3, money=500,stone=20,iron=5
{
    public int mp;

    void Start()
    {
        level = 1;
        name = "Magic Well - 1";
        mp = 30;
        Info = "Magic Well - 1\nIncrease your MP by 30.\nMagic flows in it.";
    }

    void Update()
    {
        if (level == 2)
        {
            name = "Magic Well - 2";
            mp = 40;
            Info = "Magic Well - 2\nIncrease your MP by 40.\nMagic flows in it.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("MpRecover2");
        }

        if (level == 3)
        {
            name = "Magic Well - 3(max)";
            mp = 50;
            Info = "Magic Well - 3(max)\nIncrease your MP by 50.\nMagic flows in it.";
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("MpRecover3");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            int temp = GameObject.Find("Hero").GetComponent<HeroBehavior>().MP + mp;
            if (temp > GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MP =
                    GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil;
            else
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MP = temp;
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayRecover();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainMP(mp);
            // Invoke("Obtain",0.5f);
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
                    //         ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
                    // }
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 200;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 5;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nMagic Well - 1?\nIt needs 200 gold coins and 5 stones.";
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

                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 500;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 20;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().iron = 5;
                    GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 3;
                    GameObject.Find("UpgradeText").GetComponent<Text>().text =
                        "Are you sure to upgrade\nMagic Well - 2?\nIt needs 500 gold coins, 20 stones and 5 irons.";
                }
            }
        }
        else if (Input.GetMouseButtonUp(1))
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
}