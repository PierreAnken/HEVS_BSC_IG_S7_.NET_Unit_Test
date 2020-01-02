using FiltersEdgeDetection;
using System.Drawing;

namespace DAL
{
    public class BLLBitmapManager : IBitmapManager
    {
        public Bitmap GetBitmap()
        {
            return App.originaleImage;
        }

        public void SetBitmap(Bitmap bitmap)
        {
            App.originaleImage = bitmap;
        }
    }
}
