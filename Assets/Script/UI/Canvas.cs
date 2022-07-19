using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
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
}
