namespace CommandPattern
{
    public class Stereo
    {
        public bool StereoStatus { get; private set; }
        public bool CdStatus { get; private set; }
        public int Volume { get; private set; }

        public void On()
        {
            StereoStatus = true;
        }

        public void Off()
        {
            StereoStatus = false;
            CdStatus = false;
            Volume = 0;
        }

        public void SetCd()
        {
            CdStatus = true;
        }

        public void SetVolume(int volume)
        {
            Volume = volume;
        }
    }
}