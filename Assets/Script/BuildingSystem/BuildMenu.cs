using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public static bool BuildingFlag;
    
    public Sprite Hunter;

    public Sprite HpRecover;
    
    public Sprite MpRecover;
    
    public Sprite HpStatue;
    
    public Sprite MpStatue;
    
    public Sprite AttackStatue;
    
    public Sprite DefenseStatue;
    
    public Sprite WoodSource;
    
    public Sprite StoneSource;
    
    public Sprite IronSource;
    
    public Sprite Treasure;

    public GameObject[] Buttons = new GameObject[11];
    // Start is called before the first frame update
    void Start()
    {
        BuildingFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SwitchToBuildMode()
    {
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
            GameManager.getGM.SwitchToBuilding();
    }

    //Event function
    public void ClickHunterButton()
    {
        BuildingFlag = true;
        GameObject HunterPicture = new GameObject("Hunter Picture");
        HunterPicture.AddComponent<SpriteRenderer>();
        HunterPicture.GetComponent<SpriteRenderer>().sprite = Hunter;
        HunterPicture.AddComponent<BuildingModePicture>();
        HunterPicture.GetComponent<BuildingModePicture>().targetName = "Hunter";
        HunterPicture.GetComponent<BuildingModePicture>().money = 20;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }

    public void ClickHpRecoverButton()
    {
        BuildingFlag = true;
        GameObject HpRecoverPicture = new GameObject("HpRecover Picture");
        HpRecoverPicture.AddComponent<SpriteRenderer>();
        HpRecoverPicture.GetComponent<SpriteRenderer>().sprite = HpRecover;
        HpRecoverPicture.AddComponent<BuildingModePicture>();
        HpRecoverPicture.GetComponent<BuildingModePicture>().targetName = "HpRecover";
        HpRecoverPicture.GetComponent<BuildingModePicture>().money = 80;
        // HpRecoverPicture.GetComponent<BuildingModePicture>().wood = 5;
        // HpRecoverPicture.GetComponent<BuildingModePicture>().stone = 20;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickMpRecoverButton()
    {
        BuildingFlag = true;
        GameObject HpRecoverPicture = new GameObject("MpRecover Picture");
        HpRecoverPicture.AddComponent<SpriteRenderer>();
        HpRecoverPicture.GetComponent<SpriteRenderer>().sprite = MpRecover;
        HpRecoverPicture.AddComponent<BuildingModePicture>();
        HpRecoverPicture.GetComponent<BuildingModePicture>().targetName = "MpRecover";
        HpRecoverPicture.GetComponent<BuildingModePicture>().money = 80;
        // HpRecoverPicture.GetComponent<BuildingModePicture>().wood = 5;
        // HpRecoverPicture.GetComponent<BuildingModePicture>().stone = 20;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickHpStatueButton()
    {
        BuildingFlag = true;
        GameObject HpStatuePicture = new GameObject("HpStatue Picture");
        HpStatuePicture.AddComponent<SpriteRenderer>();
        HpStatuePicture.GetComponent<SpriteRenderer>().sprite = HpStatue;
        HpStatuePicture.AddComponent<BuildingModePicture>();
        HpStatuePicture.GetComponent<BuildingModePicture>().targetName = "HpStatue";
        HpStatuePicture.GetComponent<BuildingModePicture>().money = 300;
        HpStatuePicture.GetComponent<BuildingModePicture>().wood = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickMpStatueButton()
    {
        BuildingFlag = true;
        GameObject HpStatuePicture = new GameObject("MpStatue Picture");
        HpStatuePicture.AddComponent<SpriteRenderer>();
        HpStatuePicture.GetComponent<SpriteRenderer>().sprite = MpStatue;
        HpStatuePicture.AddComponent<BuildingModePicture>();
        HpStatuePicture.GetComponent<BuildingModePicture>().targetName = "MpStatue";
        HpStatuePicture.GetComponent<BuildingModePicture>().money = 500;
        HpStatuePicture.GetComponent<BuildingModePicture>().stone = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickAttackStatueButton()
    {
        BuildingFlag = true;
        GameObject AttackStatuePicture = new GameObject("AttackStatue Picture");
        AttackStatuePicture.AddComponent<SpriteRenderer>();
        AttackStatuePicture.GetComponent<SpriteRenderer>().sprite = AttackStatue;
        AttackStatuePicture.AddComponent<BuildingModePicture>();
        AttackStatuePicture.GetComponent<BuildingModePicture>().targetName = "AttackStatue";
        AttackStatuePicture.GetComponent<BuildingModePicture>().money = 150;
        AttackStatuePicture.GetComponent<BuildingModePicture>().wood = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickDefenseStatueButton()
    {
        BuildingFlag = true;
        GameObject DefenseEquipPicture = new GameObject("DefenseStatue Picture");
        DefenseEquipPicture.AddComponent<SpriteRenderer>();
        DefenseEquipPicture.GetComponent<SpriteRenderer>().sprite = DefenseStatue;
        DefenseEquipPicture.AddComponent<BuildingModePicture>();
        DefenseEquipPicture.GetComponent<BuildingModePicture>().targetName = "DefenseStatue";
        DefenseEquipPicture.GetComponent<BuildingModePicture>().money = 150;
        DefenseEquipPicture.GetComponent<BuildingModePicture>().stone = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickWoodSourceButton()
    {
        BuildingFlag = true;
        GameObject WoodSourcePicture = new GameObject("WoodSource Picture");
        WoodSourcePicture.AddComponent<SpriteRenderer>();
        WoodSourcePicture.GetComponent<SpriteRenderer>().sprite = WoodSource;
        WoodSourcePicture.AddComponent<BuildingModePicture>();
        WoodSourcePicture.GetComponent<BuildingModePicture>().targetName = "WoodSource";
        WoodSourcePicture.GetComponent<BuildingModePicture>().money = 350;
        WoodSourcePicture.GetComponent<BuildingModePicture>().stone = 20;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickStoneSourceButton()
    {
        BuildingFlag = true;
        GameObject StoneSourcePicture = new GameObject("StoneSource Picture");
        StoneSourcePicture.AddComponent<SpriteRenderer>();
        StoneSourcePicture.GetComponent<SpriteRenderer>().sprite = StoneSource;
        StoneSourcePicture.AddComponent<BuildingModePicture>();
        StoneSourcePicture.GetComponent<BuildingModePicture>().targetName = "StoneSource";
        StoneSourcePicture.GetComponent<BuildingModePicture>().money = 350;
        StoneSourcePicture.GetComponent<BuildingModePicture>().wood = 20;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickIronSourceButton()
    {
        BuildingFlag = true;
        GameObject IronSourcePicture = new GameObject("IronSource Picture");
        IronSourcePicture.AddComponent<SpriteRenderer>();
        IronSourcePicture.GetComponent<SpriteRenderer>().sprite = IronSource;
        IronSourcePicture.AddComponent<BuildingModePicture>();
        IronSourcePicture.GetComponent<BuildingModePicture>().targetName = "IronSource";
        IronSourcePicture.GetComponent<BuildingModePicture>().money = 1500;
        IronSourcePicture.GetComponent<BuildingModePicture>().wood = 50;
        IronSourcePicture.GetComponent<BuildingModePicture>().stone = 50;
        IronSourcePicture.GetComponent<BuildingModePicture>().gem = 1;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickTreasureButton()
    {
        BuildingFlag = true;
        GameObject TreasurePicture = new GameObject("Treasure Picture");
        TreasurePicture.AddComponent<SpriteRenderer>();
        TreasurePicture.GetComponent<SpriteRenderer>().sprite = Treasure;
        TreasurePicture.AddComponent<BuildingModePicture>();
        TreasurePicture.GetComponent<BuildingModePicture>().targetName = "Treasure";
        TreasurePicture.GetComponent<BuildingModePicture>().gem = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }

    public void ClickBackButton()
    {
        GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
