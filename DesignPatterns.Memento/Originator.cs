namespace DesignPatterns.Memento
{
    public class Originator<T>
    {
        public T State { get; set; }

        public Memento<T> Redo()
        {
            return new Memento<T>(this.State);
        }

        public void Undo(Memento<T> memento)
        {
            this.State = memento.State;
        }
    }
}