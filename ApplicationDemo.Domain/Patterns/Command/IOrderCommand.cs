namespace ApplicationDemo.Domain.Command
{
    public interface IOrderCommand
    {
        void Execute();
        void Undo();
    }
}
