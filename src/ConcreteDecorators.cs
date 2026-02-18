namespace DesignPatternChallenge.Refactored
{
    // Decorador Concreto
    // Adiciona responsabilidades ao componente.
    public class Leite : CondimentDecorator
    {
        private Beverage _beverage;

        public Leite(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Leite";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.50m;
        }
    }

    // Decorador Concreto
    public class Chocolate : CondimentDecorator
    {
        private Beverage _beverage;

        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Chocolate";

        public override decimal Cost()
        {
            // Custo da bebida decorada + custo do chocolate
            return _beverage.Cost() + 0.70m;
        }
    }

    // Decorador Concreto
    public class Chantilly : CondimentDecorator
    {
        private Beverage _beverage;

        public Chantilly(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Chantilly";

        public override decimal Cost()
        {
            return _beverage.Cost() + 1.00m;
        }
    }

    // Decorador Concreto
    public class Caramelo : CondimentDecorator
    {
        private Beverage _beverage;

        public Caramelo(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Caramelo";

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.80m;
        }
    }
}
