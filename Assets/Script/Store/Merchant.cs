using System;
using UnityEngine;


public class Merchant : MonoBehaviour
{

    public bool StorePageIsOpen = false;
    public void OnMouseDown()
    {
        if (StorePageIsOpen == false)
        {
            // if (GameObject.Find("MerchantSay") != null)
            //     GameObject.Find("MerchantSay").gameObject.SetActive(false);
            if (GameObject.Find("BuildButton") != null)
                GameObject.Find("BuildButton").gameObject.SetActive(false);
            if (GameObject.Find("BagButton") != null)
                GameObject.Find("BagButton").gameObject.SetActive(false);
            GameObject.Find("StoreCanvas").transform.Find("StorePage").gameObject.SetActive(true);
            GameManager.getGM.SwitchToPause();
            StorePageIsOpen = true;
            GameManager.getGM.SwitchToBagging();
        }
    }
}