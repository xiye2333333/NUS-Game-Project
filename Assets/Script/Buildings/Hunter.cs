using System;
using UnityEngine;
using UnityEngine.UI;

public class Hunter : Building
{
    // private void Awake()
    // {
    //     BuildingInfo = GameObject.Find("BuildingInfo");
    // }

    public void Start()
    {
        // BuildingInfo = GameObject.Find("BuildingInfo");
        Hero = GameObject.Find("Hero");
        price = 10;
        Info = "Hunt monster(maybe dangerous)";
    }
    
    // private void OnMouseEnter()
    // {
    //     Debug.Log("a");
    // }
}