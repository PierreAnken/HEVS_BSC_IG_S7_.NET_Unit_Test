using DAL;
using System.Drawing;

namespace BLL
{
    public class ImageManagement
    {
        public Bitmap LoadImage(IBitmapManager bitmapManager, int maxWidth)
        {
            Bitmap bitmap = bitmapManager.GetBitmap();

            return ExtBitmap.AdaptToSquareCanvas(bitmap, maxWidth);
        }

        public void SaveImage(IBitmapManager bitmapManager, Bitmap image)
        {
            bitmapManager.SetBitmap(image);
        }
    }
}
