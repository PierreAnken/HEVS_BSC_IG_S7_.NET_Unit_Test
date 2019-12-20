using System.Drawing;

namespace FiltersEdgeDetection.Interfaces
{
    interface IImageManager
    {
        Bitmap LoadImage(string path);
        void SaveImage(string path, Bitmap img);
    }
}
