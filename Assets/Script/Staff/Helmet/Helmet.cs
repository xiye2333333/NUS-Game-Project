using Script.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Staff.Helmet
{
    public class Helmet : Equipment
    {
        public int HP;

        public int MP;//no define

        public int Defence;
        public override void PutUp()
        {
            if (BodyBlockIsEmpty())
            {
                HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
                heroBehavior.Helmet = this;
                heroBehavior.HPCeil += HP;
                heroBehavior.HP += HP;

                heroBehavior.Defense += Defence;
                GameObject HeadBlock = GameObject.Find("HeadBlock");
                HeadBlock.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpiritPath);
                HeadBlock.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                BodyBlockBehavior blockBehavior = HeadBlock.AddComponent<BodyBlockBehavior>();
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
            heroBehavior.Helmet = null;
            heroBehavior.EquipmentBag.Add(this);
            Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
            bag.UpdateEquipmentBag();
            heroBehavior.HP -= HP;
            heroBehavior.HPCeil -= HP;
            heroBehavior.Defense -= Defence;
        }

        public override bool BodyBlockIsEmpty()
        {
            HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (heroBehavior.Helmet == null)
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