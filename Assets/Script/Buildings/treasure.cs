using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class treasure : Building
{
    public int addGem = 1;
    public int day = 0;

    void Start()
    {
        level = 3;
        name = "Treasure";
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
            }
        }
    }

}