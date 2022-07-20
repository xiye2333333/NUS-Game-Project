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
    public int mpCeil = 0;
    public int attack = 0;
    public int defense = 0;

    public int level;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClickSure()
    {
        if (CanUpgrade())
        {
            Purchase();
            StatusChange();
            building.GetComponent<Building>().level++;
            // Debug.Log(building.GetComponent<Building>().level);
            // Debug.Log(GameObject.Find("Hero").GetComponent<HeroBehavior>().Level);
            money = 0;
            wood = 0;
            stone = 0;
            iron = 0;
            gem = 0;
            hpCeil = 0;
            mpCeil = 0;
            attack = 0;
            defense = 0;
            level = 0;
        }
        else
        {
            Debug.Log("Not enough resources");
        }

        // building.GetComponent<Building>().Upgrade();
        // Debug.Log(building.GetComponent<Building>().name);
        GameObject.Find("Upgrade").SetActive(false);
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
            GameManager.getGM.SwitchToRunning();
    }

    public void OnClickCancel()
    {
        GameObject.Find("Upgrade").SetActive(false);
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Upgrading)
            GameManager.getGM.SwitchToRunning();
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
        return false;
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
        GameObject.Find("Hero").GetComponent<HeroBehavior>().MPCeil += mpCeil;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Attack += attack;
        GameObject.Find("Hero").GetComponent<HeroBehavior>().Defense += defense;
    }
}