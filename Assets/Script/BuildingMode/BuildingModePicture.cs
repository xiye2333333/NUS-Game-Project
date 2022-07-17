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

    public int price;

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
        sp = GetComponent<SpriteRenderer>();
        sp.color = Color.clear;
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

        if (PositionIsValid())
        {
            Color color = new Color();
            color = Color.green;
            color.a = 0.5f;
            sp.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                //弹出确认窗口
                //Assets/Resources/Prefab/PF Village Props - Well.prefab
                GameObject target = Instantiate(Resources.Load("Prefab/" + targetName) as GameObject);
                GameManager.getGM.Buildings.Add(target);
                target.transform.position = transform.position;
                GameManager.getGM.SwitchBuildingToRunning();
                Hero.GetComponent<HeroBehavior>().Money -= price;
                Destroy(gameObject);
            }
        }
        else
        {
            Color color = new Color();
            color = Color.red;
            color.a = 0.5f;
            sp.color = color;
        }
    }

    public bool PositionIsValid()
    {
        ArrayList buildings = GameManager.getGM.Buildings; //GameObject
        // Debug.Log(buildings.Capacity);
        // Debug.Log(GetComponent<SpriteRenderer>().bounds.max.x);
        foreach (GameObject building in buildings)
        {
            // Vector3 position = building.transform.position;
            Bounds otherBounds = building.GetComponent<SpriteRenderer>().bounds;
            Bounds thisBounds = GetComponent<SpriteRenderer>().bounds;
            if (otherBounds.max.x > thisBounds.min.x && otherBounds.min.x < thisBounds.max.x)
            {
                return false;
            }
        }

        return true;
    }
}