using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using FiltersEdgeDetection.PrensentationLayer;

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
