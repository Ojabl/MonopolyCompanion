namespace MonopolyCompanion
{
    public interface ICard
    {
        public string Name { get; set; }

        public EnCardType CardType { get; set; }
    }
}