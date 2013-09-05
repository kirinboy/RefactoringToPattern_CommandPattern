namespace CommandPattern
{
    public class CeilingOffCommand
    {
        private readonly Ceiling ceiling;

        public CeilingOffCommand(Ceiling ceiling)
        {
            this.ceiling = ceiling;
        }

        public void CeilingOff()
        {
            ceiling.Off();
        }
    }
}