namespace CommandPattern
{
    public class StereoOffCommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void StereoOff()
        {
            stereo.Off();
        }
    }
}