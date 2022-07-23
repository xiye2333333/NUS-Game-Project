using System;
using UnityEngine;

namespace Script.UI
{
    public class DaySwitch : MonoBehaviour
    {
        float time;

        // private void Awake()
        // {
        //     time = Time.time;
        // }

        private void OnEnable()
        {
            time = Time.time;
        }

        private void Update()
        {
            if (Time.time - time > 2)
            {
                time = Time.time;
                gameObject.SetActive(false);
            }
        }
    }
}