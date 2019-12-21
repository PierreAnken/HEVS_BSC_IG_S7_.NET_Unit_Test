using FiltersEdgeDetection;
using System.Drawing;

namespace DAL
{
    public class BLLResultBitmapManager : IBitmapManager
    {
        public Bitmap GetBitmap()
        {
            return App.GetResultBitmap();
        }

        public void SetBitmap(Bitmap bitmap)
        {
            App.SetResultBitmap(bitmap);
        }
    }
}
