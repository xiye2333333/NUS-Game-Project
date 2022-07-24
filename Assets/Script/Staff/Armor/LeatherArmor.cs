namespace Script.Staff.Armor
{
    public class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            name = "Leather Armor";
            info = "A simple leather armor\nAdd 20 HP, 10 defence";
            HP = 20;
            MP = 0; //no define
            Defence = 10;
            SpiritPath = "Staff/Leather Armor";
        }
    }
}