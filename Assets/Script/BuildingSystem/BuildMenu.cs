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
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running || GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
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
        HunterPicture.GetComponent<BuildingModePicture>().money = 50;
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
        HpStatuePicture.GetComponent<BuildingModePicture>().money = 150;
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
        HpStatuePicture.GetComponent<BuildingModePicture>().money = 150;
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
        WoodSourcePicture.GetComponent<BuildingModePicture>().money = 200;
        WoodSourcePicture.GetComponent<BuildingModePicture>().stone = 5;
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
        StoneSourcePicture.GetComponent<BuildingModePicture>().money = 200;
        StoneSourcePicture.GetComponent<BuildingModePicture>().wood = 5;
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
        IronSourcePicture.GetComponent<BuildingModePicture>().money = 1000;
        IronSourcePicture.GetComponent<BuildingModePicture>().wood = 50;
        IronSourcePicture.GetComponent<BuildingModePicture>().stone = 50;
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
        TreasurePicture.GetComponent<BuildingModePicture>().gem = 2;
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
        text += "Monster House" + "\n";
        text += "Hunt monsters for money.\nIt is also getting stronger." + "\n";
        text += "Need: 50 gold coins";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterHPSupplyBlock()
    {
        // statue_hp_1 statue = new statue_hp_1() ;
        string text = "";
        text += "Treatment Station" + "\n";
        text += "Heal yourself by 50HP.\nBy eating, it seems." + "\n";
        text += "Need: 80 gold coins";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterMPSupplyBlock()
    {
        // statue_mp_1 statue = new statue_mp_1() ;
        string text = "";
        text += "Magic Well" + "\n";
        text += "Increase your MP by 30.\nMagic flows in it." + "\n";
        text += "Need: 80 gold coins";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterHPStatueBlock()
    {
        // supply_hp_1 statue = new supply_hp_1() ;
        string text = "";
        text += "Goddess Statue" + "\n";
        text += "Increase HP ceiling by 20.\nGoddess blesses you." + "\n";
        text += "Need: 150 gold coins and 5 woods";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterMPStatueBlock()
    {
        // supply_mp_1 statue = new supply_mp_1() ;
        string text = "";
        text += "Cross Statue" + "\n";
        text += "Decrease MP ceiling by 15%.\nReward for piety." + "\n";
        text += "Need: 150 gold coins and 5 stones";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterAttackStatueBlock()
    {
        // statue_attack_1 statue = new statue_attack_1() ;
        string text = "";
        text += "Knight Statue" + "\n";
        text += "Increase attack by 2.\nKnight gives you power." + "\n";
        text += "Need: 150 gold coins and 5 woods";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterDenfenseStatueBlock()
    {
        // statue_defense_1 statue = new statue_defense_1() ;
        string text = "";
        text += "Shield Statue" + "\n";
        text += "Increase defense by 2.\nDivine shield gives you power." + "\n";
        text += "Need: 150 gold coins and 5 stones";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterWoodSourceBlock()
    {
        // source_wood_2 statue = new source_wood_2() ;
        string text = "";
        text += "Logging Camp" + "\n";
        text += "Get 20 pieces of wood.\nIt regenerates every day." + "\n";
        text += "Need: 200 gold coins and 5 stones";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterStoneSourceBlock()
    {
        // source_stone_2 statue = new source_stone_2() ;
        string text = "";
        text += "Quarry" + "\n";
        text += "Get 20 stones.\nIt regenerates every day." + "\n";
        text += "Need: 200 gold coins and 5 woods";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterIronSourceBlock()
    {
        // source_iron_3 statue = new source_iron_3() ;
        string text = "";
        text += "Iron Area" + "\n";
        text += "Get 50 irons.\nIt regenerates every day." + "\n";
        text += "Need: 1000 gold coins, 50 woods, 50 stones";
        BuildingInfo.GetComponent<Text>().text = text;
    }

    public void EnterTresureBlock()
    {
        // treasure statue = new treasure() ;
        string text = "";
        text += "Treasure Chest" + "\n";
        text += "Get 1 gem every day.\nIt appreciates your creation." + "\n";
        text += "Need: 2 gems";
        BuildingInfo.GetComponent<Text>().text = text;
    }
}