namespace CommandPattern
{
    public class Light
    {
        public bool Status { get; private set; }

        public void On()
        {
            Status = true;
        }

        public void Off()
        {
            Status = false;
        }
    }
}