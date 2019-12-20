using FiltersEdgeDetection.Interfaces;
using System.Drawing;
using System.IO;

namespace FiltersEdgeDetection.classes
{
    class ApiPExelsImage : IImageManager
    {
        public Bitmap LoadImage(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            Bitmap  originalBitmap = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close(); 

            return originalBitmap;
        }

        public void SaveImage(string path, Bitmap img)
        {

        }
    }
}
