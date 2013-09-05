namespace CommandPattern
{
    public class CeilingHighCommand : ICommand
    {
        private readonly Ceiling ceiling;

        public CeilingHighCommand(Ceiling ceiling)
        {
            this.ceiling = ceiling;
        }

        public void Execute()
        {
            ceiling.High();
        }
    }
}