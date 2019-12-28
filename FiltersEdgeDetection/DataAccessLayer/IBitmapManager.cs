using System.Drawing;

namespace DAL
{
    public interface IBitmapManager
    {
        Bitmap GetBitmap();
        void SetBitmap(Bitmap bitmap);
    }
}
