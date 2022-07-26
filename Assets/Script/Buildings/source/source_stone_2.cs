using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
using Script.UI;
using UnityEngine;
using UnityEngine.EventSystems;
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
        addStone = 20;
        Info = "Quarry - 1\nGet 20 stones.\nIt regenerates every day.";
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 3)
        {
            name = "Quarry - 2(max)";
            addStone = 80;
            Info = "Quarry - 2(max)\nGet 80 stones.\nIt regenerates every day.";
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

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
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
                    // for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
                    // {
                    //     if (((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).name != "Hunter(Clone)")
                    //     ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
                    // }
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
    public override void Culculate()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone += addStone;
    }
}