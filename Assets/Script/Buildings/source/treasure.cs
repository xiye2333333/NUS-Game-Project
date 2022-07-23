using System;
using System.Collections;
using System.Collections.Generic;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class treasure : Building
{
    public int addGem;
    public int day = 0;

    void Start()
    {
        level = 3;
        name = "Treasure";
        addGem = 1;
        Info = "Treasure: +1 gem every 3 days";
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            day++;
            if (day % 3 == 0)
            {
                GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem += addGem;
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainGem(addGem);
            }
        }
    }

}