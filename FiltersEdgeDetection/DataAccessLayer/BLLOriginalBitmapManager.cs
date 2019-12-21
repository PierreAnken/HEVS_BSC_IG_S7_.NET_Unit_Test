using FiltersEdgeDetection;
using System.Drawing;

namespace DAL
{
    public class BLLOriginalBitmapManager : IBitmapManager
    {
        public Bitmap GetBitmap()
        {
            return App.GetOriginalBitmap();
        }

        public void SetBitmap(Bitmap bitmap)
        {
            App.SetOriginalBitmap(bitmap);
            App.ApplyFilters();
        }
    }
}
