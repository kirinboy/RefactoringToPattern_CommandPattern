namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Light light;
        private readonly Ceiling ceiling;
        private readonly Stereo stereo;

        public RemoteControl(Light light, Ceiling ceiling, Stereo stereo)
        {
            this.light = light;
            this.ceiling = ceiling;
            this.stereo = stereo;
        }

        public void On(int slot)
        {
            if (slot == 1)
                new LightOnCommand(light).Execute();
            if (slot == 2)
                new CeilingHighCommand(ceiling).Execute();
            if (slot == 3)
                new StereoOnCommand(stereo).Execute();
        }

        public void Off(int slot)
        {
            if (slot == 1)
                new LightOffCommand(light).Execute();
            if (slot == 2)
                new CeilingOffCommand(ceiling).Execute();
            if (slot == 3)
                new StereoOffCommand(stereo).Execute();
        }
    }
}