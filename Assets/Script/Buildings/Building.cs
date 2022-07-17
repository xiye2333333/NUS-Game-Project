using System;
using UnityEngine;
using UnityEngine.UI;


public class Building : MonoBehaviour
{
    public int price;

    public GameObject Hero;

    public string Info;

    public GameObject BuildingInfo;
    
    // private void Start()
    // {
    //     Hero = GameObject.Find("Hero");
    // }

    // private void Update()
    // {
    //     throw new NotImplementedException();
    // }

    private void OnMouseEnter()
    {
        BuildingInfo = GameObject.Find("BuildingInfo");
        // BuildingInfo.SetActive(true);
        BuildingInfo.GetComponent<Text>().text = Info;
    }

    private void OnMouseExit()
    {
        // BuildingInfo.SetActive(false);
        BuildingInfo.GetComponent<Text>().text = "";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<HeroBehavior>().HP -= 10;
        Debug.Log(other.GetComponent<HeroBehavior>().HP);
    }
}