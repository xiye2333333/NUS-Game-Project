using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStatusBehavior : MonoBehaviour
{
    private GameObject MoneyText;
    
    private GameObject WoodText;

    private GameObject StoneText;
    
    private GameObject IronText;
    
    private GameObject GemText;
    
    private GameObject AttackText;
    
    private GameObject DefenseText;

    private GameObject Hero;

    private GameObject HP;
    
    private GameObject MP;
    // Start is called before the first frame update
    void Start()
    {
        MoneyText = GameObject.Find("MoneyText");
        WoodText = GameObject.Find("WoodText");
        StoneText = GameObject.Find("StoneText");
        IronText = GameObject.Find("IronText");
        GemText = GameObject.Find("GemText");
        AttackText = GameObject.Find("AttackText");
        DefenseText = GameObject.Find("DefenseText");
        Hero = GameObject.Find("Hero");
        HP = GameObject.Find("HP");
        MP = GameObject.Find("MP");
    }

    // Update is called once per frame
    void Update()
    {
        int moneyNumber = Hero.GetComponent<HeroBehavior>().Money;
        int woodNumber = Hero.GetComponent<HeroBehavior>().Wood;
        int stoneNumber = Hero.GetComponent<HeroBehavior>().Stone;
        int ironNumber = Hero.GetComponent<HeroBehavior>().Iron;
        int gemNumber = Hero.GetComponent<HeroBehavior>().Gem;
        int attackNumber = Hero.GetComponent<HeroBehavior>().Attack;
        int defenseNumber = Hero.GetComponent<HeroBehavior>().Defense;
        MoneyText.GetComponent<Text>().text = "Money: " + moneyNumber;
        WoodText.GetComponent<Text>().text = "Wood: " + woodNumber;
        StoneText.GetComponent<Text>().text = "Stone: " + stoneNumber;
        IronText.GetComponent<Text>().text = "Iron: " + ironNumber;
        GemText.GetComponent<Text>().text = "Gem: " + gemNumber;
        AttackText.GetComponent<Text>().text = "Attack: " + attackNumber;
        DefenseText.GetComponent<Text>().text = "Defense: " + defenseNumber;

        int HPNumber = Hero.GetComponent<HeroBehavior>().HP;
        int MaxHPNumber = Hero.GetComponent<HeroBehavior>().HPCeil;
        HP.GetComponent<Slider>().value = (float)HPNumber / MaxHPNumber;
        
        int MPNumber = Hero.GetComponent<HeroBehavior>().MP;
        int MaxMPNumber = Hero.GetComponent<HeroBehavior>().MPCeil;
        MP.GetComponent<Slider>().value = (float)MPNumber / MaxMPNumber;
    }
}
