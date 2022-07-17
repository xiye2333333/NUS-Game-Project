using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class source_wood_2 : Building
{
    public int addWood = 3;

    void Start()
    {
        level = 2;
        name = "Wood Source 1";

    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood += addWood;
        }
    }
    
    void Upgrade()
    {
        if (CanUpgrade())
        {
            addWood = 6;
            money = 1000;
            wood = 0;
            stone = 50;
            iron = 15;
            gem = 0;
            level++;//3
            Purchase();

        }
    }
}