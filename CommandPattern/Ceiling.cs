namespace CommandPattern
{
    public enum CeilingSpeed
    {
        High,
        Medium,
        Low,
        Off
    }

    public class Ceiling
    {
        private CeilingSpeed speed;

        public void High()
        {
            speed = CeilingSpeed.High;
        }
        
        public void Medium()
        {
            speed = CeilingSpeed.Medium;
        }

        public void Low()
        {
            speed = CeilingSpeed.Low;
        }
        
        public void Off()
        {
            speed = CeilingSpeed.Off;
        }

        public CeilingSpeed GetSpeed()
        {
            return speed;
        }
    }
}