using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradingMode : MonoBehaviour
{
    public GameObject building;
    public int money = 0;
    public int wood = 0;
    public int stone = 0;
    public int iron = 0;
    public int gem = 0;

    public int hpCeil = 0;
    public float mpDecent = 1;
    public int attack = 0;
    public int defense = 0;

    public int level;

    public int addLevel = 0;


    // Start is called before the first frame update
    void Start()
    { 
        mpDecent = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
        // {
        //     if (((GameObject) (GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).name !=
        //         "Hunter(Clone)")
        //     {
        //         ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = false;
        //         Debug.Log(((GameObject)GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i]).GetComponent<BoxCollider2D>().enabled);
        //     }
        // }
    }

    public void OnClickSure()
    {
        if (CanUpgrade())
        {
            Purchase();
            StatusChange();
            building.GetComponent<Building>().level++;
            building.GetComponent<Building>().sure = true;
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayUpgrade();

            money = 0;
            wood = 0;
            stone = 0;
            iron = 0;
            gem = 0;
            hpCeil = 0;
            mpDecent = 1;
            attack = 0;
            defense = 0;
            level = 0;
            addLevel = 0;

            GameObject.Find("Upgrade").SetActive(false);
            if (GameObject.Find("Build Menu") == null)
            {
                GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
            }

            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
                GameManager.getGM.SwitchToPause();
        }
        else
        {
            if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Level < level)
            {
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nInsufficient home level!";
            }
            else
            {
                GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nNot enough resources!";
            }

            Debug.Log("Not enough resources");
            money = 0;
            wood = 0;
            stone = 0;
            iron = 0;
            gem = 0;
            hpCeil = 0;
            mpDecent = 1;
            attack = 0;
            defense = 0;
            level = 0;
            addLevel = 0;

            GameObject.Find("Upgrade").SetActive(false);
            if (GameObject.Find("Build Menu") == null)
            {
                GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
            }

            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
                GameManager.getGM.SwitchToPause();
        }
    }

    public void OnClickCancel()
    {
        money = 0;
        wood = 0;
        stone = 0;
        iron = 0;
        gem = 0;
        hpCeil = 0;
        mpDecent = 1;
        attack = 0;
        defense = 0;
        level = 0;
        addLevel = 0;
        GameObject.Find("Upgrade").SetActive(false);
        // for (int i = 0; i < GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Count; i++)
        // {
        //     ((GameObject)(GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList[i])).GetComponent<BoxCollider2D>().enabled = true;
        // }
        if (GameObject.Find("Build Menu") == null)
        {
            GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
        }

        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
            GameManager.getGM.SwitchToPause();
    }

    public bool CanUpgrade()
    {
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Money >= money &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood >= wood &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone >= stone &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Iron >= iron &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem >= gem &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Level >= level)
            return true;
        else if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Level < level)
        {
            GameObject.Find("BuildingInfo").GetComponent<Text>().text = "Upgrade Failed:\nInsufficient home level!";
            GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nInsufficient home level!";
            return false;
        }
        else
        {
            GameObject.Find("BuildingInfo").GetComponent<Text>().text = "Upgrade Failed:\nNot enough resources!";
            GameObject.Find("UpgradeText").GetComponent<Text>().text = "Upgrade Failed:\nNot enough resources!";
            return false;
        }
    }

    public void Purchase()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Money -= money;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood -= wood;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone -= stone;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Iron -= iron;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem -= gem;
    }

    public void StatusChange()
    {
        GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil += hpCeil;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().HP += hpCeil;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().HP >=
            GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().HP =
                GameObject.Find("Hero").GetComponent<HeroBehavior>().HPCeil;

        GameObject.Find("Hero").GetComponent<HeroBehavior>().MPTrue *= mpDecent;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil = (int)GameObject.Find("Hero").GetComponent<HeroBehavior>().MPTrue;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil < 0)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil = 0;
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().MP >=
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil)
            GameObject.Find("Hero").GetComponent<HeroBehavior>().MP =
                GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil;

        GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack += attack;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Defense += defense;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Level += addLevel;
    }
}