namespace CommandPattern
{
    public class StereoOnCommand
    {
        private readonly Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void StereoOn()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
    }
}