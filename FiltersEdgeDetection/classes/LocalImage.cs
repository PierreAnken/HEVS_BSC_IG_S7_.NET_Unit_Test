using FiltersEdgeDetection.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersEdgeDetection.classes
{
    class LocalImage : IImageManager
    {
        public Bitmap LoadImage(string path)
        {
            Bitmap originalBitmap = null;

            StreamReader streamReader = new StreamReader(path);
            originalBitmap = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close(); 

            return originalBitmap;
        }

        public void SaveImage(string path, Bitmap img)
        {

        }
    }
}
