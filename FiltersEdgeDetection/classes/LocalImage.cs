using FiltersEdgeDetection.Interfaces;
using System.Drawing;
using System.IO;

namespace FiltersEdgeDetection.classes
{
    class LocalImage : IImageManager
    {
        readonly string path;

        public LocalImage(string path) {
            this.path = path;
        }

        public Bitmap LoadImage()
        {
            StreamReader streamReader = new StreamReader(path);
            Bitmap  originalBitmap = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close(); 

            return originalBitmap;
        }

        public void SaveImage(Bitmap img)
        {

        }
    }
}
