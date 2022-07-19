using System.Collections;
using System.Collections.Generic;
using Script.Staff;
using Script.Store;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StoreBehavior : MonoBehaviour
{
    public GameObject StoreText;

    public GameObject Helm1;

    public GameObject Helm2;

    public GameObject Helm3;

    public GameObject Armor1;

    public GameObject Armor2;

    public GameObject Armor3;

    public GameObject Boot1;

    public GameObject Boot2;

    public GameObject Sword1;

    public GameObject Sword2;

    public GameObject Sword3;

    public GameObject Sword4;

    public GameObject Shield1;

    public GameObject Shield2;

    public GameObject Potion1;

    public GameObject Potion2;

    public GameObject InfoPicture;

    public GameObject InfoText;

    public GameObject Hero;
    
    // Start is called before the first frame update
    
    
    void Start()
    {
        Hero = GameObject.Find("Hero");
        // Text text = InfoText.GetComponent<Text>();
        // StoreText.transform.position = transform.position + Vector3.up * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hero.transform.position.x > -16)
        {
            Destroy(gameObject);
        }
    }

    // public void AddEvent(GameObject GO)
    // {
    //     EventTrigger eventTrigger = GO.AddComponent<EventTrigger>();
    //     EventTrigger.Entry entry = new EventTrigger.Entry();
    //     entry.eventID = EventTriggerType.PointerEnter;
    //     
    // }

    public void EnterHelm1()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Leather Helmet" + "\n";
        info += "Money: "+ LeatherHelmetPrice.Money + "\n";
        info += LeatherHelmetPrice.Info;
        text.text = info;
        // text.text = LeatherHelmetPrice.
    }

    public void EnterSword1()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Knife" + "\n";
        info += "Money: "+ KnifePrice.Money + "\n";
        info += KnifePrice.Info;
        text.text = info;
    }

    public void ExitOneStaff()
    {
        InfoPicture.gameObject.SetActive(false);
    }

    public void OnClickMerchant()
    {
        // transform.Find("Build Menu").gameObject.SetActive(true);
        // Debug.Log(11);
        // GameObject.Find("BuildButton").gameObject.SetActive(false);
        // GameObject.Find("BagButton").gameObject.SetActive(false);
        // transform.Find("Canvas").Find("StorePage").gameObject.SetActive(true);
    }

    public void OnClickKnife()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (heroBehavior.Money >= KnifePrice.Money)
        {
            heroBehavior.EquipmentBag.Add(new Knife());
            heroBehavior.Money -= KnifePrice.Money;
            Debug.Log("Buy a Knife");
        }
        else
        {
            Debug.Log("Money not enough");
        }

        // Debug.Log("ClickHelm1");
    }

    public void OnClickExit()
    {
        if (GameObject.Find("Build Menu") == null)
        {
            GameObject.Find("Canvas").transform.Find("BuildButton").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("BagButton").gameObject.SetActive(true);
        }
        // GameObject.Find("MerchantSay").gameObject.SetActive(false);
        // GameObject.Find("BuildButton").gameObject.SetActive(true);
        // GameObject.Find("BagButton").gameObject.SetActive(false);
        GameObject.Find("StoreCanvas").transform.Find("StorePage").gameObject.SetActive(false);
        GameManager.getGM.SwitchToRunning();
        GameObject.Find("Merchant").GetComponent<Merchant>().StorePageIsOpen = false;
    }
}
