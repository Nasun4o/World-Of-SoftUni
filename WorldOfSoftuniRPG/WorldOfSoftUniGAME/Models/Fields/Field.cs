namespace WorldOfSoftuniRPG.Models.Fields
{
    using WorldOfSoftuniRPG.Models.Players;

    public abstract class Field
    {
        public static Hero Hero { get; set; }

        public static string PrintHero()
        {         
            return Hero == null ? "No hero." : Hero.ToString();
        }
    }
}