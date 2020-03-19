using System;

namespace SolidViolations.InterfaceSegregation
{
    //film camera can't record videos
    public class FilmCamera: ICamera
    {
        public void TakePicture()
        {
            Console.WriteLine("I am a film camera and I can take a picture");
        }

        
        public void RecordVideo()
        {
            throw new NotSupportedException("I am a film camera and I can't record videos");
        }
    }
}
