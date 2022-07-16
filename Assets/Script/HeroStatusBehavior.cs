using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStatusBehavior : MonoBehaviour
{
    private GameObject MoneyText;

    private GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        MoneyText = GameObject.Find("MoneyText");
        Hero = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {

        int moneyNumber = Hero.GetComponent<HeroBehavior>().Money;
        MoneyText.GetComponent<Text>().text = "Money: " + moneyNumber;
    }
}
