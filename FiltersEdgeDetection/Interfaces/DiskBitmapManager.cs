using FiltersEdgeDetection.Interfaces;
using System.Drawing;
using System.IO;

namespace FiltersEdgeDetection.classes
{
    class DiskBitmapManager : IBitmapManager
    {
        readonly string diskPath;

        public DiskBitmapManager(string diskPath) {
            this.diskPath = diskPath;
        }

        public Bitmap GetBitmap()
        {
            StreamReader streamReader = new StreamReader(diskPath);
            Bitmap  originalBitmap = (Bitmap)Image.FromStream(streamReader.BaseStream);
            streamReader.Close();

            return originalBitmap;
        }

        public void SetBitmap(Bitmap img)
        {

        }
    }
}
