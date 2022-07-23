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

    private GameObject HPText;

    private GameObject MPText;

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
        HPText = GameObject.Find("HPtext");
        MPText = GameObject.Find("MPtext");
        

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
        MoneyText.GetComponent<Text>().text =""+moneyNumber;
        WoodText.GetComponent<Text>().text = "" + woodNumber;
        StoneText.GetComponent<Text>().text = "" + stoneNumber;
        IronText.GetComponent<Text>().text = "" + ironNumber;
        GemText.GetComponent<Text>().text = "" + gemNumber;
        AttackText.GetComponent<Text>().text = "" + attackNumber;
        DefenseText.GetComponent<Text>().text = "" + defenseNumber;

        int HPNumber = Hero.GetComponent<HeroBehavior>().HP;
        int MaxHPNumber = Hero.GetComponent<HeroBehavior>().HPCeil;
        HP.GetComponent<Slider>().value = (float) HPNumber / MaxHPNumber;

        int MPNumber = Hero.GetComponent<HeroBehavior>().MP;
        int MaxMPNumber = Hero.GetComponent<HeroBehavior>().MPCeil;
        MP.GetComponent<Slider>().value = (float) MPNumber / MaxMPNumber;
        
        HPText.GetComponent<Text>().text = "" + HPNumber + "/" + MaxHPNumber;
        MPText.GetComponent<Text>().text = "" + MPNumber + "/" + MaxMPNumber;
    }
}