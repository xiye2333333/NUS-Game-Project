using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingModePicture : MonoBehaviour
{
    public string targetName = null;

    public GameObject Hero;

    private SpriteRenderer sp;

    public BuildMenu BuildMenu;

    // public int price;

    public int money = 0;
    public int wood = 0;
    public int stone = 0;
    public int iron = 0;
    public int gem = 0;

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
        sp = GetComponent<SpriteRenderer>();
        sp.color = Color.clear;
        BuildMenu = GameObject.Find("Build Menu").GetComponent<BuildMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        // SpriteRenderer sp = GetComponent<SpriteRenderer>();
        // Vector2 size = sp.size;
        // float y = 0f + size.y / 2;
        mousePosition.y = 0;
        transform.position = mousePosition;

        if (PositionIsValid() && CanPurchase())
        {
            Color color = new Color();
            color = Color.green;
            color.a = 0.5f;
            sp.color = color;
            if (Input.GetMouseButtonUp(0))
            {
                //弹出确认窗口
                //Assets/Resources/Prefab/PF Village Props - Well.prefab
                GameObject target = Instantiate(Resources.Load("Prefab/" + targetName) as GameObject);
                //Debug.Log(target.name);
                GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingList.Add(target);
                GameObject.Find("Hero").GetComponent<HeroBehavior>().BuildingLevelList.Add(1);
                GameManager.getGM.Buildings.Add(target);
                target.transform.position = transform.position;
                if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Building)
                    GameManager.getGM.SwitchToPause();
                Purchase();
                foreach (GameObject button in BuildMenu.Buttons)
                {
                    button.gameObject.SetActive(true);
                }

                GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayPlace();
                Destroy(gameObject);
                BuildMenu.BuildingFlag = false;
            }
        }
        else
        {
            Color color = new Color();
            color = Color.red;
            color.a = 0.5f;
            sp.color = color;
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject.Find("AudioEffect").GetComponent<AudioManager>().PlayFail();
            foreach (GameObject button in BuildMenu.Buttons)
            {
                button.gameObject.SetActive(true);
            }

            Destroy(gameObject);
            BuildMenu.BuildingFlag = false;
            if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Building)
                GameManager.getGM.SwitchToPause();
        }
    }

    public bool PositionIsValid()
    {
        Bounds thisBounds = GetComponent<SpriteRenderer>().bounds;
        if (thisBounds.min.x < -24.5f || thisBounds.max.x > 27f)
            return false;
        ArrayList buildings = GameManager.getGM.Buildings; //GameObject
        // Debug.Log(buildings.Count);
        // Debug.Log(GetComponent<SpriteRenderer>().bounds.max.x);
        foreach (GameObject building in buildings)
        {
            // Vector3 position = building.transform.position;
            Bounds otherBounds = building.GetComponent<SpriteRenderer>().bounds;
            if (otherBounds.max.x > thisBounds.min.x && otherBounds.min.x < thisBounds.max.x)
            {
                return false;
            }
        }

        return true;
    }

    public bool CanPurchase()
    {
        if (GameObject.Find("Hero").GetComponent<HeroBehavior>().Money >= money &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Wood >= wood &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Stone >= stone &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Iron >= iron &&
            GameObject.Find("Hero").GetComponent<HeroBehavior>().Gem >= gem)
            return true;
        return false;
    }

    public void Purchase()
    {
        Hero.GetComponent<HeroBehavior>().Money -= money;
        Hero.GetComponent<HeroBehavior>().Wood -= wood;
        Hero.GetComponent<HeroBehavior>().Stone -= stone;
        Hero.GetComponent<HeroBehavior>().Iron -= iron;
        Hero.GetComponent<HeroBehavior>().Gem -= gem;
    }
}