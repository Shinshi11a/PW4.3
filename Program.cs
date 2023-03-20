public class Orc
{
    public static int TotalGoldCarried { get; private set; } = 0;
    public int GoldCarried { get; private set; } = 0;

    public Orc()
    {
        GoldCarried = 2;
        TotalGoldCarried += GoldCarried;
        if (TotalGoldCarried > 10)
        {
            GoldCarried -= 2;
            TotalGoldCarried -= 2;
        }
    }
}