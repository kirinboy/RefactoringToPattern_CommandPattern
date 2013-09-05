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
                new LightOnCommand(light).LightOn();
            if (slot == 2)
                new CeilingHighCommand(ceiling).CeilingHigh();
            if (slot == 3)
                new StereoOnCommand(stereo).StereoOn();
        }

        public void Off(int slot)
        {
            if (slot == 1)
                new LightOffCommand(light).LightOff();
            if (slot == 2)
                new CeilingOffCommand(ceiling).CeilingOff();
            if (slot == 3)
                new StereoOffCommand(stereo).StereoOff();
        }
    }
}