using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public bool isDoubleSpeed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBuildButton()
    {
        transform.Find("Build Menu").gameObject.SetActive(true);
        transform.Find("BuildButton").gameObject.SetActive(false);
        transform.Find("BagButton").gameObject.SetActive(false);
    }

    public void OnClickBagButton()
    {
        transform.Find("Bag").gameObject.SetActive(true);
        transform.Find("BuildButton").gameObject.SetActive(false);
        transform.Find("BagButton").gameObject.SetActive(false);
        transform.Find("Bag").gameObject.GetComponent<Bag>().UpdateEquipmentBag();
        if (GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
            GameManager.getGM.SwitchToBagging();
    }

    public void OnClickSpeedButton(GameObject button)
    {
        if (isDoubleSpeed)
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().TrueSpeed = 1f;
            if(GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().Speed = 1f;
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/normal");
            isDoubleSpeed = false;
        }
        else
        {
            GameObject.Find("Hero").GetComponent<HeroBehavior>().TrueSpeed = 5f;
            if(GameManager.getGM.GetGameStatus() == GameManager.GameStatus.Running)
                GameObject.Find("Hero").GetComponent<HeroBehavior>().Speed = 5f;
            //Assets/Resources/uiui/quick.png
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/quick");
            isDoubleSpeed = true;
        }

    }
}
