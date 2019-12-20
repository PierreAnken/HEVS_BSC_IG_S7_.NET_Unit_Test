using System.Drawing;

namespace FiltersEdgeDetection.Interfaces
{
    interface IImageManager
    {
        Bitmap load(string path);
        void save(string path, Bitmap img);
    }
}
