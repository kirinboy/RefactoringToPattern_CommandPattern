namespace CommandPattern
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
    }
}