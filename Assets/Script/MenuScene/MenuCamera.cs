using System;
using UnityEngine;

namespace Script.MenuScene
{
    public class MenuCamera : MonoBehaviour
    {
        public GameObject Hero;
        private void Update()
        {
            Vector3 pos = Hero.transform.position;
            pos.y = 3.92f;
            pos.z = -10;
            transform.position = pos;
        }
    }
}