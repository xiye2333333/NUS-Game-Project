using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gm;

    public static GameManager getGM{
        get{
            return gm;
        }
    }
    private GameObject Hero;

    private GameStatus _gameStatus = GameStatus.Running;

    private ArrayList buildings = new ArrayList();//type: GameObject
    public enum GameStatus
    {
        Pause,
        Running,
        Building
    }

    private void Awake()
    {
        gm = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Hero = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchRunningToPause()
    {
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Pause;
    }

    public void SwitchRunningToBuilding()
    {
        Hero.GetComponent<HeroBehavior>().Speed = 0f;
        _gameStatus = GameStatus.Building;
    }

    public void SwitchBuildingToRunning()
    {
        Hero.GetComponent<HeroBehavior>().Speed = 1f;
        _gameStatus = GameStatus.Running;
    }

    public ArrayList Buildings
    {
        get => buildings;
        set => buildings = value;
    }
}
