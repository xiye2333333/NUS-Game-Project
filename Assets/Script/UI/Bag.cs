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

    public GameObject MpText;

    public GameObject AttackText;

    public GameObject DefenceText;

    public GameObject GoldText;

    public GameObject WoodText;

    public GameObject StoneText;

    public GameObject IronText;

    public GameObject GemText;
    
    public HeroBehavior Hero;

    public GameObject[] EquipmentBagBlock = new GameObject[16];
    
    public GameObject[] EquipmentBagBack = new GameObject[16];

    public Sprite EquipmentBagBlockSprite;
    // Start is called before the first frame update
    private void Awake()
    {
        Hero = GameObject.Find("Hero").GetComponent<HeroBehavior>();
        Hero = GameObject.Find("Hero").GetComponent<HeroBehavior>();
        UpdateText();
        InitialEquipmentBag();
    }

    void Start()
    {

        
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
        MpText.GetComponent<Text>().text = Hero.MP + "/" + Hero.MPCeil;
        AttackText.GetComponent<Text>().text = Hero.Attack.ToString();
        DefenceText.GetComponent<Text>().text = Hero.Defense.ToString();
        GoldText.GetComponent<Text>().text = Hero.Money.ToString();
        WoodText.GetComponent<Text>().text = Hero.Wood.ToString();
        StoneText.GetComponent<Text>().text = Hero.Stone.ToString();
        IronText.GetComponent<Text>().text = Hero.Iron.ToString();
        GemText.GetComponent<Text>().text = Hero.Gem.ToString();
    }

    public void InitialEquipmentBag()
    {
        // Debug.Log(Hero.EquipmentBag.Count);
        for (int i = 0; i < Hero.EquipmentBag.Count; i++)
        {
            EquipmentBagBlock[i].GetComponent<Image>().sprite =
                Resources.Load<Sprite>(((Equipment) Hero.EquipmentBag[i]).SpiritPath);
            // EquipmentBagBlock[i].GetComponent<RectTransform>().sizeDelta = new Vector2(40, 40);
            EquipmentBagBlockBehavior blockBehavior = EquipmentBagBlock[i].AddComponent<EquipmentBagBlockBehavior>();
            blockBehavior.Equipment = (Equipment)Hero.EquipmentBag[i];
            blockBehavior.isPutOn = false;
            blockBehavior.selfSprite = EquipmentBagBlockSprite;
            blockBehavior.back = EquipmentBagBack[i];
            // Debug.Log(((Equipment) Hero.EquipmentBag[i]).SpiritPath);
        }
        
    }

    public void UpdateEquipmentBag()
    {
        foreach (GameObject block in EquipmentBagBlock)
        {
            if (block.GetComponent<EquipmentBagBlockBehavior>() != null)
            {
                Destroy(block.GetComponent<EquipmentBagBlockBehavior>());
                block.GetComponent<Image>().sprite = EquipmentBagBlockSprite;
            }
        }
        InitialEquipmentBag();
    }

    public void OnClickExitButton()
    {
        GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
        if (GameManager.getGM.GetGameStatus() != GameManager.GameStatus.Pause)
            GameManager.getGM.SwitchToPause();
        gameObject.SetActive(false);
    }

    public void OnPointerEnterBlock(GameObject gameObject)
    {
        gameObject.GetComponent<Image>().color = new Color(109/255f, 205/255f, 205/255f, 255f);
    }
    
    public void OnPointerExitBlock(GameObject gameObject)
    {
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
    }
}
