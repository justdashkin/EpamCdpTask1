namespace SolidViolations.InterfaceSegregation
{
    //we suppose that if device has camera, it is able to take pictures and videos,
    //but what if some devices could only do one of these?
    //It must be 2 separate interfaces

    interface ICamera
    {
        void TakePicture();
        void RecordVideo();
    }
}
