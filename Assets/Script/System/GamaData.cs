using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script.System
{
    public class GamaData : MonoBehaviour
    {
        public bool isChallenge = false;
        
        public float MusicVolume = 0.5f;
        
        private void Awake()
        {
            
            DontDestroyOnLoad(gameObject);
        }
        
    }
}