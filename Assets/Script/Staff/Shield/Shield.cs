using Script.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Staff.Shield
{
    public class Shield:Equipment
    {

        public int Defence;
        public override void PutUp()
        {
            if (BodyBlockIsEmpty())
            {
                HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
                heroBehavior.Shield = this;

                heroBehavior.Defense += Defence;
                GameObject ShieldBlock = GameObject.Find("ShieldBlock");
                ShieldBlock.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpiritPath);
                ShieldBlock.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                BodyBlockBehavior blockBehavior = ShieldBlock.AddComponent<BodyBlockBehavior>();
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
            heroBehavior.Shield = null;
            heroBehavior.EquipmentBag.Add(this);
            Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
            bag.UpdateEquipmentBag();
            heroBehavior.Defense -= Defence;
        }

        public override bool BodyBlockIsEmpty()
        {
            HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (heroBehavior.Shield == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}