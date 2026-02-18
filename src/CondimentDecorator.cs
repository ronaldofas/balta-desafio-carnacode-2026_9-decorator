namespace DesignPatternChallenge.Refactored
{
    // Decorador Base
    // Mantém uma referência para um objeto Componente e define uma interface que conforma à interface do Componente.
    public abstract class CondimentDecorator : Beverage
    {
        // Forçamos a implementação de Description para garantir que
        // os decoradores modifiquem a descrição do componente que envolvem.
        public abstract override string Description { get; }
    }
}
