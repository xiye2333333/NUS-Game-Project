using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStatusBehavior : MonoBehaviour
{
    private GameObject MoneyText;

    private GameObject Hero;

    private GameObject HP;
    private GameObject Day;
    // Start is called before the first frame update
    void Start()
    {
        MoneyText = GameObject.Find("MoneyText");
        Hero = GameObject.Find("Hero");
        HP = GameObject.Find("HP");
        Day = GameObject.Find("Day");
    }

    // Update is called once per frame
    void Update()
    {
        //Day.GetComponent<Text>().text = TimeManager.getTM.TimeMassege();
        int moneyNumber = Hero.GetComponent<HeroBehavior>().Money;
        MoneyText.GetComponent<Text>().text = "Money: " + moneyNumber;

        int HPNumber = Hero.GetComponent<HeroBehavior>().HP;
        int MaxHPNumber = Hero.GetComponent<HeroBehavior>().MaxHP;
        HP.GetComponent<Slider>().value = (float)HPNumber / MaxHPNumber;
    }
}
