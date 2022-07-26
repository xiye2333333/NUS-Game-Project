using Script.UI;
using UnityEngine;

namespace Script.Skill
{
    public class HolyLight : Skill
    {
        public HolyLight()
        {
            name = "Holy Light";
            info = "Attack enemy with a holy light\nAdd 15% of max HP";
            SpiritPath = "Skill/Icon11";
        }
        public override void Use(GameObject target, bool isBoss)
        {
            HeroBehavior hero = GameObject.Find("Hero").GetComponent<HeroBehavior>();
            if (!isBoss)
            {
                target.GetComponent<MonsterBehavior>().isHit(hero.Attack);
                if(hero.HP + hero.HPCeil * 0.15 <= hero.HPCeil)
                {
                    hero.HP += (int)(hero.HPCeil * 0.15);
                }
                else
                {
                    hero.HP = hero.HPCeil;
                }
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().UseHolyLight();
            }
            else
            {
                target.GetComponent<BossBehavior>().isHit(hero.Attack);
                if(hero.HP + hero.HPCeil * 0.2 <= hero.HPCeil)
                {
                    hero.HP += (int)(hero.HPCeil * 0.2);
                }
                else
                {
                    hero.HP = hero.HPCeil;
                }
                GameObject.Find("HeroCanvas").GetComponent<HeroCanvas>().UseHolyLight();
            }
        }
    }
}