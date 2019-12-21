using System.Drawing;

namespace FiltersEdgeDetection.Interfaces
{
    interface IBitmapManager
    {
        Bitmap GetBitmap();
        void SetBitmap(Bitmap bitmap);
    }
}
