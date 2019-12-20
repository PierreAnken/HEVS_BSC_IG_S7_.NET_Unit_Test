using System.Drawing;

namespace FiltersEdgeDetection.Interfaces
{
    interface IImageManager
    {
        Bitmap LoadImage();
        void SaveImage(Bitmap img);
    }
}
