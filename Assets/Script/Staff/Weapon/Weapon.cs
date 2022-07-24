using Script.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Staff
{
    public class Weapon : Equipment
    {
        public int Attack;

        public override void PutUp()
        {
            if (BodyBlockIsEmpty())
            {
                HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
                heroBehavior.Weapon = this;
                heroBehavior.Attack += Attack;
                GameObject WeaponBlock = GameObject.Find("WeaponBlock");
                WeaponBlock.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpiritPath);
                WeaponBlock.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                BodyBlockBehavior blockBehavior = WeaponBlock.AddComponent<BodyBlockBehavior>();
                blockBehavior.Equipment = this;
                heroBehavior.EquipmentBag.Remove(this);
                // Debug.Log("Bag size:" + heroBehavior.EquipmentBag.Count);
            }
            else
            {
                //huan zhuang bei
            }
        }

        public override void PutDown()
        {
            HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            heroBehavior.Weapon = null;
            heroBehavior.EquipmentBag.Add(this);
            Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
            bag.UpdateEquipmentBag();
            heroBehavior.Attack -= Attack;
        }

        public override bool BodyBlockIsEmpty()
        {
            HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (heroBehavior.Weapon == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Use(GameObject target, bool isBoss)
        {
            
        }
    }
}