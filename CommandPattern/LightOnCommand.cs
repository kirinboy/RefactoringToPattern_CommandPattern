namespace CommandPattern
{
    public class LightOnCommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void LightOn()
        {
            light.On();
        }
    }
}