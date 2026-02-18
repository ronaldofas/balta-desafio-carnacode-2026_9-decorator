namespace DesignPatternChallenge.Refactored
{
    // Componente Abstrato
    // Define a interface para os objetos que podem ter responsabilidades adicionadas dinamicamente.
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Bebida Desconhecida";

        public abstract decimal Cost();
    }
}
