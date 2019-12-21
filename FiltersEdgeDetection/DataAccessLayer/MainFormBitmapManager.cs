using BLL;
using FiltersEdgeDetection.PrensentationLayer;
using System;
using System.Drawing;

namespace DAL
{
    public class MainFormBitmapManager : IBitmapManager
    {
        private readonly MainForm mainForm;
        
        public MainFormBitmapManager(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public Bitmap GetBitmap()
        {
            throw new NotImplementedException();
        }

        public void SetBitmap(Bitmap bitmap)
        {
            System.Windows.Forms.PictureBox preview = mainForm.GetImagePreview();
            preview.Image = ExtBitmap.AdaptToSquareCanvas(bitmap, preview.Width);
        }
    }
}
