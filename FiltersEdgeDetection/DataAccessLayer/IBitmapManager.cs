using System.Drawing;

namespace DAL
{
    interface IBitmapManager
    {
        Bitmap GetBitmap();
        void SetBitmap(Bitmap bitmap);
    }
}
