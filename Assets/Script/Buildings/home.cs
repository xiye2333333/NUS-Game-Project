using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class home : Building
// statue_mp_1: mpCeil-1; money=500, stone=5
// statue_mp_2: hpCeil-2; money=1000, stone=20, iron=10
// statue_mp_3: hpCeil-3; money=2500, stone=50, iron=20, gem=2
{
    public int homeLevel;

    void Start()
    {
        level = 1;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Level = 1;
    }
    
    void Update()
    {
        Info = "Home level " + level;
        if (sure)
        {
            //Assets/Resources/home2.png
            GameObject.Find("StartCamp").GetComponent<SpriteRenderer>().sprite =
                Resources.Load<Sprite>("home"+GameObject.Find("Hero").GetComponent<HeroBehavior>().Level);
            GameObject.Find("EndCamp").GetComponent<SpriteRenderer>().sprite =
                Resources.Load<Sprite>("home"+GameObject.Find("Hero").GetComponent<HeroBehavior>().Level);
            sure = false;
        }
    }

    private void OnMouseUp()
    {
        if (level == 1)
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayClick();
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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 500;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 1;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().addLevel = 1;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Do you want to upgrade your home?\nIt will offer more diverse and advanced buildings.\nIt needs 500 gold coins.";
            }
        }

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

                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().money = 1500;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().wood = 60;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().stone = 60;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().level = 2;
                GameObject.Find("Upgrade").GetComponent<UpgradingMode>().addLevel = 1;
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Do you want to upgrade your home?\nIt will offer more diverse and advanced buildings.\nIt needs 1500 gold coins, 60 woods and 60 stones.";
            }
        }
    }
    
}