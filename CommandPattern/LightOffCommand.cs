namespace CommandPattern
{
    public class LightOffCommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void LightOff()
        {
            light.Off();
        }
    }
}