using System;
using UnityEngine;

namespace Script.System
{
    public class GamaData : MonoBehaviour
    {
        public bool isChallenge = false;
        private void Awake()
        {
            
            DontDestroyOnLoad(gameObject);
        }
    }
}