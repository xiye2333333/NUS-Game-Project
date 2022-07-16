using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingModePicture : MonoBehaviour
{
    public string targetName = null;

    public GameObject Hero; 

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
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

        if (Input.GetMouseButtonDown(0))
        {
            //弹出确认窗口
            //Assets/Resources/Prefab/PF Village Props - Well.prefab
            GameObject Hunter = Instantiate(Resources.Load("Prefab/PF Village Props - Well") as GameObject);
            Hunter.transform.position = transform.position;
            GameManager.getGM.SwitchBuildingToRunning();
            Hero.GetComponent<HeroBehavior>().Money -= 10;
            
            Destroy(gameObject);
        }
    }
}