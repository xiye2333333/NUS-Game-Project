using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager gm;

    public static GameManager getGM{
        get{
            return gm;
        }
    }
    private GameObject Hero;

    private GameObject Boss;

    private GameStatus _gameStatus = GameStatus.Pause;

    private GameObject PauseButton;

    private ArrayList buildings = new ArrayList();//type: GameObject
    public enum GameStatus
    {
        Pause,
        Running,
        Building,
        Upgrading,
        Bagging
    }

    private void Awake()
    {
        gm = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
        Boss = GameObject.Find("Boss");
        PauseButton = GameObject.FindGameObjectWithTag("PauseButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (_gameStatus == GameStatus.Pause)
                SwitchToRunning();
            else if (_gameStatus == GameStatus.Running)
                SwitchToPause();
        }

        if (_gameStatus == GameStatus.Running){
            Hero.GetComponent<HeroBehavior>().Speed = Canvas.SpeedRate;
            Boss.GetComponent<BossBehavior>().Speed = Canvas.SpeedRate * 2;
        }
    }

    public GameStatus GetGameStatus(){
        return _gameStatus;
    }
    public void SwitchToPause()
    {
        PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/pause");
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        Boss.GetComponent<BossBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Pause;
    }

    public void SwitchToBuilding()
    {
        PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/pause");
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        Boss.GetComponent<BossBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Building;
    }

    public void SwitchToUpgrading()
    {
        PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/pause");
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        Boss.GetComponent<BossBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Upgrading;
    }

    public void SwitchToBagging()
    {
        PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/pause");
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        Boss.GetComponent<BossBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Bagging;
    }

    public void SwitchToRunning()
    {
        PauseButton.GetComponent<Image>().sprite = Resources.Load<Sprite>("uiui/running");
        Hero.GetComponent<HeroBehavior>().Speed = Canvas.SpeedRate;
        Boss.GetComponent<BossBehavior>().Speed = Canvas.SpeedRate * 2;
        _gameStatus = GameStatus.Running;
    }

    public ArrayList Buildings
    {
        get => buildings;
        set => buildings = value;
    }
}
