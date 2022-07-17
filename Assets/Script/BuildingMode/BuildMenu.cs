using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Sprite Hunter;

    public Sprite HpRecover;
    
    public Sprite HpStatue;
    
    public Sprite AttackEquip;
    
    public Sprite WoodSource;
    
    public Sprite Treasure;

    public GameObject[] Buttons = new GameObject[6];//0:Hunter,1:HpRecover,2:HpStatue,3:AttackEquip,4:WoodSource,5:Treasure
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SwitchToBuildMode()
    {
        GameManager.getGM.SwitchToBuilding();
    }

    //Event function
    public void ClickHunterButton()
    {
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
    
    public void ClickHpStatueButton()
    {
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
    
    public void ClickAttackEquipButton()
    {
        GameObject AttackEquipPicture = new GameObject("AttackEquip Picture");
        AttackEquipPicture.AddComponent<SpriteRenderer>();
        AttackEquipPicture.GetComponent<SpriteRenderer>().sprite = AttackEquip;
        AttackEquipPicture.AddComponent<BuildingModePicture>();
        AttackEquipPicture.GetComponent<BuildingModePicture>().targetName = "AttackEquip";
        AttackEquipPicture.GetComponent<BuildingModePicture>().money = 150;
        AttackEquipPicture.GetComponent<BuildingModePicture>().wood = 5;
        foreach (GameObject button in Buttons)
        {
            button.gameObject.SetActive(false);
        }
        SwitchToBuildMode();
    }
    
    public void ClickWoodSourceButton()
    {
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
    
    public void ClickTreasureButton()
    {
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
}
