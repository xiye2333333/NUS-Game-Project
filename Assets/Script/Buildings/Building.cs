using System;
using UnityEngine;
using UnityEngine.UI;


public class Building : MonoBehaviour
{
    // public GameObject Hero;
    
    public int money;
    public int wood;
    public int stone;
    public int iron;
    public int gem;
    
    public int level;
    
    public string name;
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
        // BuildingInfo.transform.position = gameObject.transform.position;????
        BuildingInfo.GetComponent<Text>().text = Info;
        
    }

    private void OnMouseExit()
    {
        // BuildingInfo.SetActive(false);
        BuildingInfo.GetComponent<Text>().text = "";
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     other.GetComponent<HeroBehavior>().HP -= 10;
    //     Debug.Log(other.GetComponent<HeroBehavior>().HP);
    // }

    // private void OnMouseDown()
    // {
    //     
    // }
    //
    // public void Upgrade()
    // {
    //     Debug.Log(3);
    // }

    // public bool CanUpgrade()
    // {
    //     if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Money >= money &&
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood >= wood &&
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone >= stone &&
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().Iron >= iron &&
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem >= gem &&
    //         GameObject.Find("Hero").GetComponent<HeroBehavior>().Level >= level)
    //         return true;
    //     return false;
    // }
    //
    // public void Purchase()
    // {
    //     Hero.GetComponent<HeroBehavior>().Money -= money;
    //     Hero.GetComponent<HeroBehavior>().Wood -= wood;
    //     Hero.GetComponent<HeroBehavior>().Stone -= stone;
    //     Hero.GetComponent<HeroBehavior>().Iron -= iron;
    //     Hero.GetComponent<HeroBehavior>().Gem -= gem;
    // }
    //
}