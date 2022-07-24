using Script.Staff;
using Script.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Skill
{
    public class Skill : Equipment
    {

        public override void PutUp()
        {
            if (BodyBlockIsEmpty())
            {
                HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
                heroBehavior.Skill = this;
                GameObject SkillBlock = GameObject.Find("SkillBlock");
                SkillBlock.GetComponent<Image>().sprite = Resources.Load<Sprite>(SpiritPath);
                SkillBlock.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                BodyBlockBehavior blockBehavior = SkillBlock.AddComponent<BodyBlockBehavior>();
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
            heroBehavior.Skill = null;
            heroBehavior.EquipmentBag.Add(this);
            Bag bag = GameObject.Find("Bag").GetComponent<Bag>();
            bag.UpdateEquipmentBag();
        }

        public override bool BodyBlockIsEmpty()
        {
            HeroBehavior heroBehavior = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (heroBehavior.Skill == null)
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