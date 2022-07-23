using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject[] Buttons = new GameObject[12];

    public GameObject BuildingInfo;

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

    public void EnterHunterBlock()
    {
        // hunted_house house = new hunted_house();
        string text = "";
        text += "Hunted house" + "\n";
        text += "Hunt monsters for money. May be dangerous." + "\n";
        text += "Money: 20" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterHPStatueBlock()
    {
        // statue_hp_1 statue = new statue_hp_1() ;
        string text = "";
        text += "HP Statue" + "\n";
        text += "HP Statue 1: hpCeil+10" + "\n";
        text += "Money: 300 Wood: 5" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterMPStatueBlock()
    {
        // statue_mp_1 statue = new statue_mp_1() ;
        string text = "";
        text += "MP Statue 1" + "\n";
        text += "MP Statue 1: mpCeil-1" + "\n";
        text += "Money: 300 Stone: 5" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterHPSupplyBlock()
    {
        // supply_hp_1 statue = new supply_hp_1() ;
        string text = "";
        text += "HP Supply" + "\n";
        text += "HP Supply 1: hp+50" + "\n";
        text += "Money: 80" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterMPSupplyBlock()
    {
        // supply_mp_1 statue = new supply_mp_1() ;
        string text = "";
        text += "MP Supply" + "\n";
        text += "MP Supply 1: mp+1" + "\n";
        text += "Money: 80" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterAttackStatueBlock()
    {
        // statue_attack_1 statue = new statue_attack_1() ;
        string text = "";
        text += "Attack Statue" + "\n";
        text += "Attack Statue 1: attack+5" + "\n";
        text += "Money: 150 Wood: 5" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterDenfenseStatueBlock()
    {
        // statue_defense_1 statue = new statue_defense_1() ;
        string text = "";
        text += "Defense Statue" + "\n";
        text += "Defense Statue 1: defense+5" + "\n";
        text += "Money: 150 Stone: 5" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterWoodSourceBlock()
    {
        // source_wood_2 statue = new source_wood_2() ;
        string text = "";
        text += "Wood Source 1" + "\n";
        text += "Wood Source 1: wood+3" + "\n";
        text += "Money: 350 Stone: 20" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterStoneSourceBlock()
    {
        // source_stone_2 statue = new source_stone_2() ;
        string text = "";
        text += "Stone Source" + "\n";
        text += "Stone Source 1: stone+3" + "\n";
        text += "Money: 350 Wood: 20" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterIronSourceBlock()
    {
        // source_iron_3 statue = new source_iron_3() ;
        string text = "";
        text += "Source Iron" + "\n";
        text += "Source Iron: iron+2" + "\n";
        text += "Money: 1500 Wood: 50 Stone: 50 Gem: 1" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterTresureBlock()
    {
        // treasure statue = new treasure() ;
        string text = "";
        text += "Treasure" + "\n";
        text += "Treasure: +1 gem every 3 days" + "\n";
        text += "Gem: 5" + "\n";
        BuildingInfo.GetComponent<Text>().text = text;
    }
}