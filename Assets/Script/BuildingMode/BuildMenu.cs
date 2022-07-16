using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Sprite Hunter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SwitchToBuildMode()
    {
        GameManager.getGM.SwitchRunningToBuilding();
    }

    //Event function
    public void ClickHunterButton()
    {
        GameObject HunterPicture = new GameObject("Hunter Picture");
        HunterPicture.AddComponent<SpriteRenderer>();
        HunterPicture.GetComponent<SpriteRenderer>().sprite = Hunter;

        HunterPicture.AddComponent<BuildingModePicture>();
        HunterPicture.GetComponent<BuildingModePicture>().targetName = "Hunter";
        SwitchToBuildMode();
    }
}
