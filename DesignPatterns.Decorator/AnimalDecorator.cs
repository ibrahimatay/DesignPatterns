namespace DesignPatterns.Decorator
{
    public abstract class AnimalDecorator : IAnimal
    {
        protected readonly IAnimal Context;

        public AnimalDecorator(IAnimal animal)
        {
            Context = animal;
        }
        
        public virtual void Describe()
        {
            Context.Describe();
        }
    }
}