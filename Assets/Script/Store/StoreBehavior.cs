using System.Collections;
using System.Collections.Generic;
using Script.Staff;
using Script.Staff.Armor;
using Script.Staff.Boot;
using Script.Staff.Helmet;
using Script.Staff.Shield;
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

    public GameObject CurrentObject;
    
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
            gameObject.SetActive(false);
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
        // Debug.Log(Helm1.GetComponent<Image>().color);
        Helm1.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Helm1;
        // text.text = LeatherHelmetPrice.
    }
    
    public void EnterHelm2()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Normal Helmet" + "\n";
        info += "Money: "+ HelmetPrice.Money + "\n";
        info += "Wood: " + HelmetPrice.Wood + "\n";
        info += "Stone: " + HelmetPrice.Stone + "\n";
        info += HelmetPrice.Info;
        Helm2.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Helm2;
        text.text = info;
    }

    public void EnterHelm3()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Helmet" + "\n";
        info += "Money: "+ IronHelmetPrice.Money + "\n";
        info += "Wood: " + IronHelmetPrice.Wood + "\n";
        info += "Stone: " + IronHelmetPrice.Stone + "\n";
        info += "Iron: " + IronHelmetPrice.Iron + "\n";
        info += "Gem: " + IronHelmetPrice.Gem + "\n";
        info += HelmetPrice.Info;
        text.text = info;
        Helm3.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Helm3;
    }
    
    public void EnterArmor1()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Leather Armor" + "\n";
        info += "Money: "+ LeatherArmorPrice.Money + "\n";
        info += LeatherArmorPrice.Info;
        text.text = info;
        Armor1.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Armor1;
    }
    
    public void EnterArmor2()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Wooden Armor" + "\n";
        info += "Money: "+ WoodArmorPrice.Money + "\n";
        info += "Wood: " + WoodArmorPrice.Wood + "\n";
        info += "Stone: " + WoodArmorPrice.Stone + "\n";
        info += "Iron: " + WoodArmorPrice.Iron + "\n";
        info += "Gem: " + WoodArmorPrice.Gem + "\n";
        info += WoodArmorPrice.Info;
        text.text = info;
        Armor2.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Armor2;
    }

    public void EnterArmor3()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Armor" + "\n";
        info += "Money: "+ IronArmorPrice.Money + "\n";
        info += "Wood: " + IronArmorPrice.Wood + "\n";
        info += "Stone: " + IronArmorPrice.Stone + "\n";
        info += "Iron: " + IronArmorPrice.Iron + "\n";
        info += "Gem: " + IronArmorPrice.Gem + "\n";
        info += IronArmorPrice.Info;
        text.text = info;
        Armor3.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Armor3;
    }
    
    public void EnterBoot1()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Leather Boot" + "\n";
        info += "Money: "+ LeatherBootPrice.Money + "\n";
        info += LeatherBootPrice.Info;
        text.text = info;
        Boot1.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Boot1;
    }
    
    public void EnterBoot2()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Boot" + "\n";
        info += "Money: "+ IronBootPrice.Money + "\n";
        info += "Wood: " + IronBootPrice.Wood + "\n";
        info += "Stone: " + IronBootPrice.Stone + "\n";
        info += "Iron: " + IronBootPrice.Iron + "\n";
        // info += "Gem: " + IronBootPrice.Gem + "\n";
        info += IronBootPrice.Info;
        text.text = info;
        Boot2.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Boot2;
    }
    
    public void EnterShield1()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Wooden Shield" + "\n";
        info += "Money: "+ WoodShieldPrice.Money + "\n";
        info += "Wood: " + WoodShieldPrice.Wood + "\n";
        info += WoodShieldPrice.Info;
        text.text = info;
        Shield1.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Shield1;
    }

    public void EnterShield2()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Shield" + "\n";
        info += "Money: "+ IronShieldPrice.Money + "\n";
        info += "Wood: " + IronShieldPrice.Wood + "\n";
        info += "Stone: " + IronShieldPrice.Stone + "\n";
        info += "Iron: " + IronShieldPrice.Iron + "\n";
        info += "Gem: " + IronShieldPrice.Gem + "\n";
        info += IronShieldPrice.Info;
        text.text = info;
        Shield2.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Shield2;
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
        Sword1.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Sword1;
    }
    
    public void EnterSword2()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Wooden Sword" + "\n";
        info += "Money: "+ WoodSwordPrice.Money + "\n";
        info += "Wood: " + WoodSwordPrice.Wood + "\n";
        info += WoodSwordPrice.Info;
        text.text = info;
        Sword2.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Sword2;
    }
    
    public void EnterSword4()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Sword" + "\n";
        info += "Money: "+ GoldSwordPrice.Money + "\n";
        info += "Wood: " + GoldSwordPrice.Wood + "\n";
        info += "Stone: " + GoldSwordPrice.Stone + "\n";
        info += "Iron: " + GoldSwordPrice.Iron + "\n";
        info += "Gem: " + IronSwordPrice.Gem + "\n";
        info += GoldSwordPrice.Info;
        text.text = info;
        Sword4.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Sword4;
    }

    public void EnterSword3()
    {
        InfoPicture.gameObject.SetActive(true);
        Text text = InfoText.GetComponent<Text>();
        string info = "";
        info += "Iron Sword" + "\n";
        info += "Money: "+ IronSwordPrice.Money + "\n";
        info += "Wood: " + IronSwordPrice.Wood + "\n";
        info += "Stone: " + IronSwordPrice.Stone + "\n";
        info += "Iron: " + IronSwordPrice.Iron + "\n";
        // info += "Gem: " + IronSwordPrice.Gem + "\n";
        info += IronSwordPrice.Info;
        text.text = info;
        Sword3.GetComponent<Image>().color = new Color(255/255f,165/255f,165/255f,255/255f);
        CurrentObject = Sword3;
    }

    public void ExitOneStaff()
    {
        InfoPicture.gameObject.SetActive(false);
        CurrentObject.GetComponent<Image>().color = new Color(255/255f,255/255f,255/255f,255/255f);
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
        if (SourceIsEnough(KnifePrice.Money,KnifePrice.Wood,KnifePrice.Stone,KnifePrice.Iron,KnifePrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new Knife());
            heroBehavior.Money -= KnifePrice.Money;
            Debug.Log("Buy a Knife");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }
    
    public void OnClickWoodSword()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(WoodSwordPrice.Money,WoodSwordPrice.Wood,WoodSwordPrice.Stone,WoodSwordPrice.Iron,WoodSwordPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new WoodenSword());
            heroBehavior.Money -= WoodSwordPrice.Money;
            heroBehavior.Wood -= WoodSwordPrice.Wood;
            heroBehavior.Stone -= WoodSwordPrice.Stone;
            heroBehavior.Iron -= WoodSwordPrice.Iron;
            heroBehavior.Gem -= WoodSwordPrice.Gem;
            Debug.Log("Buy a Wood Sword");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }
    
    public void OnClickIronSword()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(IronSwordPrice.Money,IronSwordPrice.Wood,IronSwordPrice.Stone,IronSwordPrice.Iron,IronSwordPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new IronSword());
            heroBehavior.Money -= IronSwordPrice.Money;
            heroBehavior.Wood -= IronSwordPrice.Wood;
            heroBehavior.Stone -= IronSwordPrice.Stone;
            heroBehavior.Iron -= IronSwordPrice.Iron;
            heroBehavior.Gem -= IronSwordPrice.Gem;
            Debug.Log("Buy a Iron Sword");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }
    
    public void OnClickGoldSword()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(GoldSwordPrice.Money,GoldSwordPrice.Wood,GoldSwordPrice.Stone,GoldSwordPrice.Iron,GoldSwordPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new GoldenSword());
            heroBehavior.Money -= GoldSwordPrice.Money;
            heroBehavior.Wood -= GoldSwordPrice.Wood;
            heroBehavior.Stone -= GoldSwordPrice.Stone;
            heroBehavior.Iron -= GoldSwordPrice.Iron;
            heroBehavior.Gem -= GoldSwordPrice.Gem;
            Debug.Log("Buy a Gold Sword");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }
    
    public void OnClickWoodShield()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(WoodShieldPrice.Money,WoodShieldPrice.Wood,WoodShieldPrice.Stone,WoodShieldPrice.Iron,WoodShieldPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new WoodenShield());
            heroBehavior.Money -= WoodShieldPrice.Money;
            heroBehavior.Wood -= WoodShieldPrice.Wood;
            heroBehavior.Stone -= WoodShieldPrice.Stone;
            heroBehavior.Iron -= WoodShieldPrice.Iron;
            heroBehavior.Gem -= WoodShieldPrice.Gem;
            Debug.Log("Buy a Wooden Shield");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }
    
    public void OnClickIronShield()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(IronShieldPrice.Money,IronShieldPrice.Wood,IronShieldPrice.Stone,IronShieldPrice.Iron,IronShieldPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new IronShield());
            heroBehavior.Money -= IronShieldPrice.Money;
            heroBehavior.Wood -= IronShieldPrice.Wood;
            heroBehavior.Stone -= IronShieldPrice.Stone;
            heroBehavior.Iron -= IronShieldPrice.Iron;
            heroBehavior.Gem -= IronShieldPrice.Gem;
            Debug.Log("Buy a Iron Shield");
        }
        else
        {
            Debug.Log("Source not enough");
        }
        
    }

    public void OnClickLeatherHelmet()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(LeatherHelmetPrice.Money,LeatherHelmetPrice.Wood,LeatherHelmetPrice.Stone,LeatherHelmetPrice.Iron,LeatherHelmetPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new LeatherHelmet());
            heroBehavior.Money -= LeatherHelmetPrice.Money;
            heroBehavior.Wood -= LeatherHelmetPrice.Wood;
            heroBehavior.Stone -= LeatherHelmetPrice.Stone;
            heroBehavior.Iron -= LeatherHelmetPrice.Iron;
            heroBehavior.Gem -= LeatherHelmetPrice.Gem;
            Debug.Log("Buy a Leather Helmet");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }

    public void OnClickHelmet()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(HelmetPrice.Money,HelmetPrice.Wood,HelmetPrice.Stone,HelmetPrice.Iron,HelmetPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new NormalHelmet());
            heroBehavior.Money -= HelmetPrice.Money;
            heroBehavior.Wood -= HelmetPrice.Wood;
            heroBehavior.Stone -= HelmetPrice.Stone;
            heroBehavior.Iron -= HelmetPrice.Iron;
            heroBehavior.Gem -= HelmetPrice.Gem;
            Debug.Log("Buy a Normal Helmet");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }

    public void OnClickIronHelmet()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(IronHelmetPrice.Money,IronHelmetPrice.Wood,IronHelmetPrice.Stone,IronHelmetPrice.Iron,IronHelmetPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new IronHelmet());
            heroBehavior.Money -= IronHelmetPrice.Money;
            heroBehavior.Wood -= IronHelmetPrice.Wood;
            heroBehavior.Stone -= IronHelmetPrice.Stone;
            heroBehavior.Iron -= IronHelmetPrice.Iron;
            heroBehavior.Gem -= IronHelmetPrice.Gem;
            Debug.Log("Buy a Iron Helmet");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }
    
    public void OnClickLeatherArmor()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(LeatherArmorPrice.Money,LeatherArmorPrice.Wood,LeatherArmorPrice.Stone,LeatherArmorPrice.Iron,LeatherArmorPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new LeatherArmor());
            heroBehavior.Money -= LeatherArmorPrice.Money;
            heroBehavior.Wood -= LeatherArmorPrice.Wood;
            heroBehavior.Stone -= LeatherArmorPrice.Stone;
            heroBehavior.Iron -= LeatherArmorPrice.Iron;
            heroBehavior.Gem -= LeatherArmorPrice.Gem;
            Debug.Log("Buy a Leather Armor");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }

    public void OnClickWoodArmor()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(WoodArmorPrice.Money,WoodArmorPrice.Wood,WoodArmorPrice.Stone,WoodArmorPrice.Iron,WoodArmorPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new WoodenArmor());
            heroBehavior.Money -= WoodArmorPrice.Money;
            heroBehavior.Wood -= WoodArmorPrice.Wood;
            heroBehavior.Stone -= WoodArmorPrice.Stone;
            heroBehavior.Iron -= WoodArmorPrice.Iron;
            heroBehavior.Gem -= WoodArmorPrice.Gem;
            Debug.Log("Buy a Wooden Armor");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }
    
    public void OnClickIronArmor()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(IronArmorPrice.Money,IronArmorPrice.Wood,IronArmorPrice.Stone,IronArmorPrice.Iron,IronArmorPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new IronArmor());
            heroBehavior.Money -= IronArmorPrice.Money;
            heroBehavior.Wood -= IronArmorPrice.Wood;
            heroBehavior.Stone -= IronArmorPrice.Stone;
            heroBehavior.Iron -= IronArmorPrice.Iron;
            heroBehavior.Gem -= IronArmorPrice.Gem;
            Debug.Log("Buy a Iron Armor");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }
    
    public void OnClickLeatherBoots()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(LeatherBootPrice.Money,LeatherBootPrice.Wood,LeatherBootPrice.Stone,LeatherBootPrice.Iron,LeatherBootPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new LeatherBoot());
            heroBehavior.Money -= LeatherBootPrice.Money;
            heroBehavior.Wood -= LeatherBootPrice.Wood;
            heroBehavior.Stone -= LeatherBootPrice.Stone;
            heroBehavior.Iron -= LeatherBootPrice.Iron;
            heroBehavior.Gem -= LeatherBootPrice.Gem;
            Debug.Log("Buy a Leather Boots");
        }
        else
        {
            Debug.Log("Source not enough");
        }
    }

    public void OnClickIronBoot()
    {
        Hero = GameObject.Find("Hero");
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (SourceIsEnough(IronBootPrice.Money,IronBootPrice.Wood,IronBootPrice.Stone,IronBootPrice.Iron,IronBootPrice.Gem))
        {
            heroBehavior.EquipmentBag.Add(new IronBoot());
            heroBehavior.Money -= IronBootPrice.Money;
            heroBehavior.Wood -= IronBootPrice.Wood;
            heroBehavior.Stone -= IronBootPrice.Stone;
            heroBehavior.Iron -= IronBootPrice.Iron;
            heroBehavior.Gem -= IronBootPrice.Gem;
            Debug.Log("Buy a Iron Boots");
        }
        else
        {
            Debug.Log("Source not enough");
        }
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
    
    public bool SourceIsEnough(int money, int wood, int stone, int iron, int gem)
    {
        HeroBehavior heroBehavior = Hero.GetComponent<HeroBehavior>();
        if (money <= heroBehavior.Money && wood <= heroBehavior.Wood && stone <= heroBehavior.Stone && iron <= heroBehavior.Iron && gem <= heroBehavior.Gem)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisableBlock(GameObject gameObject)//限制购买一次
    {
        gameObject.SetActive(false);
    }
}
