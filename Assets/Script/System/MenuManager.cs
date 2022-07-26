using System.Collections;
using System.Collections.Generic;
using Script.System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject PlayButton;

    //public GameObject systemButton;

    //public GameObject buildingFunctionButton;

    public GameObject ExitButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEasyButton()
    {
        GameObject.Find("GameData").GetComponent<GamaData>().isChallenge = false;
        GameObject.Find("GameData").GetComponent<GamaData>().MusicVolume =
            GameObject.Find("MusicManager").GetComponent<AudioSource>().volume;
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void OnClickChallengeButton()
    {
        GameObject.Find("GameData").GetComponent<GamaData>().isChallenge = true;
        GameObject.Find("GameData").GetComponent<GamaData>().MusicVolume =
            GameObject.Find("MusicManager").GetComponent<AudioSource>().volume;
        SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }

    public void OnClickSettingButton()
    {
        
    }

    // public void OnClickBuildingFunctionButton()
    // {
    //     SceneManager.LoadScene("Scenes/BuildingFunction");
    // }

    // public void OnClickBattleScene()
    // {
    //     SceneManager.LoadScene("Scenes/BattleScene");
    // }

    // public void OnClickBossScene()
    // {
    //     SceneManager.LoadScene("Scenes/Boss");
    // }
}
