using Script.UI;
using UnityEngine;

namespace Script.Skill
{
    public class Bash : Skill
    {
        public Bash()
        {
            name = "Bash";
            info = "Bash the enemy\nMake 2 times damage";
            SpiritPath = "Skill/Icon13";
        }
        
        public override void Use(GameObject target, bool isBoss)
        {
            HeroBehavior hero = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (!isBoss)
            {
                target.GetComponent<MonsterBehavior>().isHit(hero.Attack * 2);
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().UseBash();
            }
            else
            {
                target.GetComponent<BossBehavior>().isHit(hero.Attack * 2);
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().UseBash();
            }
        }
    }
}