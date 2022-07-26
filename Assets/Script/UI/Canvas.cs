using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public static int SpeedRate = 1;
    public GameObject SpeedButton; 
    // Start is called before the first frame update
    void Start()
    {
        SpeedButton = GameObject.FindGameObjectWithTag("SpeedButton");
        SpeedRate = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)){
            SwitchSpeed(SpeedButton);
        }
    }

    public void OnClickBuildButton()
    {
        transform.Find("Build Menu").gameObject.SetActive(true);
        transform.Find("BuildButton").gameObject.SetActive(false);
        transform.Find("BagButton").gameObject.SetActive(false);
    }

    public void OnClickBagButton()
    {
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running ||
            GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Pause)
        {
            GameManager.getGM.SwitchToBagging();
            transform.Find("Bag").gameObject.SetActive(true);
            transform.Find("BuildButton").gameObject.SetActive(false);
            transform.Find("BagButton").gameObject.SetActive(false);
            transform.Find("Bag").gameObject.GetComponent<Bag>().UpdateEquipmentBag();
        }
    }

    public void OnClickSpeedButton(GameObject button)
    {
        SwitchSpeed(button);
    }

    public void SwitchSpeed(GameObject button){
        if (SpeedRate == 5)
        {
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/normal");
            SpeedRate = 1;
        }
        else if (SpeedRate == 1)
        {
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/quick");
            SpeedRate = 3;
        }
        else if (SpeedRate == 3)
        {
            //Assets/Resources/uiui/veryquick.png
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/veryquick");
            SpeedRate = 5;
        }
    }

    public void OnClickPauseButton(GameObject button){
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running){
            GameManager.getGM.SwitchToPause();
        }
        else{
            GameManager.getGM.SwitchToRunning();
        }
    }
}
