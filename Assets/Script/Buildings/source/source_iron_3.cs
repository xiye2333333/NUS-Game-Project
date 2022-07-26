using System;
using System.Collections;
using System.Collections.Generic;
using Script.BuildingSystem;
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
        name = "Iron Area(max)";
        addIron = 50;
        Info = "Iron Area(max)\nGet 50 irons.\nIt regenerates every day.";
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

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(1))
        {
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
                GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
            {
                if (GameObject.Find("Build Menu") != null)
                    GameObject.Find("Build Menu").SetActive(false);
                if (GameObject.Find("BuildButton") != null)
                    GameObject.Find("BuildButton").gameObject.SetActive(false);
                if (GameObject.Find("BagButton") != null)
                    GameObject.Find("BagButton").gameObject.SetActive(false);
                GameManager.getGM.SwitchToUpgrading();
                
                GameObject.Find("Canvas").transform.Find("PullDown").gameObject.SetActive(true);
                GameObject.Find("PullDown").GetComponent<PullDown>().TargetBuilding = gameObject;
            }
        }
    }

}