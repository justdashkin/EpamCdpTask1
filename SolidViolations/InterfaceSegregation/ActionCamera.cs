using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.InterfaceSegregation
{
    //action camera can't take pictures

    public class ActionCamera: ICamera
    {
        public void TakePicture()
        {
            throw new NotSupportedException("I am an action camera and I can't take pictures");
        }

        public void RecordVideo()
        {
            Console.WriteLine("I am an action camera and I can record a video");
        }
    }
}
