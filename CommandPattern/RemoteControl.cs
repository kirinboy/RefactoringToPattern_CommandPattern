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
                light.On();
            if (slot == 2)
                ceiling.High();
            if (slot == 3)
            {
                stereo.On();
                stereo.SetCd();
                stereo.SetVolume(11);
            }
        }

        public void Off(int slot)
        {
            if (slot == 1)
                light.Off();
            if (slot == 2)
                ceiling.Off();
            if (slot == 3)
                stereo.Off();
        }
    }
}