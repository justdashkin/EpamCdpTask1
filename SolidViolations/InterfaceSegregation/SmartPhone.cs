using System;

namespace SolidViolations.InterfaceSegregation
{
    //for smart phone it is ok - it can do both
    public class SmartPhone: ICamera
    {
        public void TakePicture()
        {
            Console.WriteLine("I am a smart phone and I can take a picture");
        }

        public void RecordVideo()
        {
            Console.WriteLine("I am a smart phone and I can record a video");
        }
    }
}
