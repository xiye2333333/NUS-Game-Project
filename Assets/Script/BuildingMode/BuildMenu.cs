using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Sprite Hunter;

    public Sprite HpRecover;
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
        HunterPicture.GetComponent<BuildingModePicture>().price = 10;
        SwitchToBuildMode();
    }

    public void ClickHpRecoverButton()
    {
        GameObject HpRecoverPicture = new GameObject("HpRecover Picture");
        HpRecoverPicture.AddComponent<SpriteRenderer>();
        HpRecoverPicture.GetComponent<SpriteRenderer>().sprite = HpRecover;

        HpRecoverPicture.AddComponent<BuildingModePicture>();
        HpRecoverPicture.GetComponent<BuildingModePicture>().targetName = "HpRecover";
        HpRecoverPicture.GetComponent<BuildingModePicture>().price = 20;
        SwitchToBuildMode();
    }
}
