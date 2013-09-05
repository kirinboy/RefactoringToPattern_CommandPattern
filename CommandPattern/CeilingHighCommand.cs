namespace CommandPattern
{
    public class CeilingHighCommand
    {
        private readonly Ceiling ceiling;

        public CeilingHighCommand(Ceiling ceiling)
        {
            this.ceiling = ceiling;
        }

        public void CeilingHigh()
        {
            ceiling.High();
        }
    }
}