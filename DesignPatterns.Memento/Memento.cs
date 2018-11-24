namespace DesignPatterns.Memento
{
    public class Memento<T>
    {
        public T State { get; }

        public Memento(T state)
        {
            this.State = state;
        }
    }
}