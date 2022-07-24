namespace Script.Staff.Helmet
{
    public class NormalHelmet : Helmet
    {
        public NormalHelmet()
        {
            name = "Normal Helmet";
            info = "A good helmet\nAdd 50 HP, 15 defence";
            HP = 50;
            MP = 0;
            Defence = 15;
            SpiritPath = "Staff/Helm";
        }
    }
}