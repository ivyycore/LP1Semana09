namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        int ICanFly.NumberOfWings => 2;
        int IMammal.NumberOfNipples => 2;
        public override string Sound()
        {
            return base.Sound() + "eee-ee-ee";
        }
    }
}