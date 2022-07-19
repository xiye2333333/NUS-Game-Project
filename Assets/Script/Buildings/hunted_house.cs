using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class hunted_house : Building
{
    void Start()
    {
        name = "Hunted House";
        Info = "Hunt monsters for money. May be dangerous.";
    }
    
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject Monster = Instantiate(Resources.Load("Prefab/Monster A") as GameObject);
            Monster.transform.position = gameObject.transform.position;
        }
    }

}