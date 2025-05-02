namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        int ICanFly.NumberOfWings => 4;
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }
    }
}