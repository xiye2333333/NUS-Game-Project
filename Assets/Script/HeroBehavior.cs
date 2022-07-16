using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBehavior : MonoBehaviour
{
    private int HP;

    private int MP;

    private int Attack;

    private int Defence;

    public int Money = 100;

    public float Speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        MP = 50;
        Attack = 10;
        Defence = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = GetComponent<Transform>().position;
        position += Vector3.right * Speed * Time.smoothDeltaTime;
        GetComponent<Transform>().position = position;
    }
}
