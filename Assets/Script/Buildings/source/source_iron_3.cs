using System;
using System.Collections;
using System.Collections.Generic;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class source_iron_3 : Building
// source_iron_1: iron+2; money=1500, wood=50, stone=50, gem=1
{
    public int addIron;

    void Start()
    {
        level = 3;
        name = "Source Iron";
        addIron = 2;
        Info = "Source Iron: iron+2";
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Iron += addIron;
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayWood();
            GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().ObtainIron(addIron);
        }
    }

}