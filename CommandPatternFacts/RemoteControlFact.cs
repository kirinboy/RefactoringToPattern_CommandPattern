using CommandPattern;
using Xunit;

namespace CommandPatternFacts
{
    public class RemoteControlFact
    {
        [Fact]
        public void should_turn_on_light_when_press_first_on_button()
        {
            var light = new Light();
            var remoteControl = new RemoteControl();
            remoteControl.SetOnCommand(1, new LightOnCommand(light));
            remoteControl.On(1);
            Assert.True(light.Status);
        }
        
        [Fact]
        public void should_turn_off_light_when_press_first_off_button()
        {
            var light = new Light();
            var remoteControl = new RemoteControl();
            remoteControl.SetOffCommand(1, new LightOffCommand(light));
            remoteControl.Off(1);
            Assert.False(light.Status);
        }

        [Fact]
        public void should_turn_on_ceiling_when_press_second_on_button()
        {
            var ceiling = new Ceiling();
            var remoteControl = new RemoteControl();
            remoteControl.SetOnCommand(2, new CeilingHighCommand(ceiling));
            remoteControl.On(2);
            Assert.Equal(CeilingSpeed.High, ceiling.GetSpeed());
        }
        
        [Fact]
        public void should_turn_off_ceiling_when_press_second_off_button()
        {
            var ceiling = new Ceiling();
            var remoteControl = new RemoteControl();
            remoteControl.SetOffCommand(2, new CeilingOffCommand(ceiling));
            remoteControl.Off(2);
            Assert.Equal(CeilingSpeed.Off, ceiling.GetSpeed());
        }

        [Fact]
        public void should_turn_on_stereo_when_press_third_on_button()
        {
            var stereo = new Stereo();
            var remoteControl = new RemoteControl();
            remoteControl.SetOnCommand(3, new StereoOnCommand(stereo));
            remoteControl.On(3);
            Assert.True(stereo.StereoStatus);
            Assert.True(stereo.CdStatus);
            Assert.Equal(11, stereo.Volume);
        }
        
        [Fact]
        public void should_turn_off_stereo_when_press_third_off_button()
        {
            var stereo = new Stereo();
            var remoteControl = new RemoteControl();
            remoteControl.SetOffCommand(3, new StereoOffCommand(stereo));
            remoteControl.Off(3);
            Assert.False(stereo.StereoStatus);
            Assert.False(stereo.CdStatus);
            Assert.Equal(0, stereo.Volume);
        }
    }
}