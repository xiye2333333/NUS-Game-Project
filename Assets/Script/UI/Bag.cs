using System;
using System.Collections;
using System.Collections.Generic;
using Script.Staff;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    public GameObject HeartText;

    public GameObject AttackText;

    public GameObject DefenceText;

    public GameObject GoldText;

    public GameObject WoodText;

    public GameObject StoneText;

    public GameObject IronText;

    public HeroBehavior Hero;

    public GameObject[] EquipmentBagBlock = new GameObject[12];

    public Sprite EquipmentBagBlockSprite;
    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero").GetComponent<HeroBehavior>();
        UpdateText();
        InitialEquipmentBag();
        
    }

    // private void OnEnable()
    // {
    //     UpdateText();
    // }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        HeartText.GetComponent<Text>().text = Hero.HP + "/" + Hero.HPCeil;
        AttackText.GetComponent<Text>().text = Hero.Attack.ToString();
        DefenceText.GetComponent<Text>().text = Hero.Defense.ToString();
        GoldText.GetComponent<Text>().text = Hero.Money.ToString();
        WoodText.GetComponent<Text>().text = Hero.Wood.ToString();
        StoneText.GetComponent<Text>().text = Hero.Stone.ToString();
        IronText.GetComponent<Text>().text = Hero.Iron.ToString();
    }

    public void InitialEquipmentBag()
    {
        for (int i = 0; i < Hero.EquipmentBag.Count; i++)
        {
            EquipmentBagBlock[i].GetComponent<Image>().sprite =
                Resources.Load<Sprite>(((Equipment) Hero.EquipmentBag[i]).SpiritPath);
            EquipmentBagBlockBehavior blockBehavior = EquipmentBagBlock[i].AddComponent<EquipmentBagBlockBehavior>();
            blockBehavior.Equipment = (Equipment)Hero.EquipmentBag[i];
            blockBehavior.isPutOn = false;
            blockBehavior.selfSprite = EquipmentBagBlockSprite;
            Debug.Log(((Equipment) Hero.EquipmentBag[i]).SpiritPath);
        }
        
    }

    public void UpdateEquipmentBag()
    {
        foreach (GameObject block in EquipmentBagBlock)
        {
            if (block.GetComponent<EquipmentBagBlockBehavior>() != null)
            {
                Destroy(block.GetComponent<EquipmentBagBlockBehavior>());
                GetComponent<Image>().sprite = EquipmentBagBlockSprite;
            }
        }
        InitialEquipmentBag();
    }

    public void OnClickExitButton()
    {
        GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
        if (GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Pause)
            GameManager.getGM.SwitchToRunning();
        gameObject.SetActive(false);
    }
}
