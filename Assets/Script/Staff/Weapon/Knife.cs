using Script.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Staff
{
    public class Knife : Weapon
    {
        public int Money = 200;
        public int Wood = 0;
        public int Stone = 0;
        public int Iron = 0;
        public int Gem = 0;

        public Knife()
        {
            SpiritPath = "Staff/Knife";
            Attack = 5;
        }
        
    }
}