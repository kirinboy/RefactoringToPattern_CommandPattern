namespace CommandPattern
{
    public class CeilingOffCommand : ICommand
    {
        private readonly Ceiling ceiling;

        public CeilingOffCommand(Ceiling ceiling)
        {
            this.ceiling = ceiling;
        }

        public void Execute()
        {
            ceiling.Off();
        }
    }
}