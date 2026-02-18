namespace DesignPatternChallenge.Refactored
{
    // Componente Concreto
    // O objeto base que será decorado.
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override decimal Cost()
        {
            return 3.50m;
        }
    }

    // Componente Concreto
    public class Cappuccino : Beverage
    {
        public Cappuccino()
        {
            Description = "Cappuccino";
        }

        public override decimal Cost()
        {
            return 4.50m;
        }
    }

    // Componente Concreto (Exemplo extra)
    public class Cha : Beverage
    {
        public Cha()
        {
            Description = "Chá";
        }

        public override decimal Cost()
        {
            return 2.50m;
        }
    }
}
