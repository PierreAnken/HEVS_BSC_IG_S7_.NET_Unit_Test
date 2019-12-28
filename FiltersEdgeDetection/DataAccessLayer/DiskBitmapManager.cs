using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DAL
{
    public class DiskBitmapManager : IBitmapManager
    {
        public Bitmap GetBitmap()
        {
            Bitmap originalBitmap = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an image file.";
                ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Bitmap Images(*.bmp)|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    originalBitmap = (Bitmap)Image.FromStream(streamReader.BaseStream);
                    streamReader.Close();
                }
            }

            return originalBitmap;
        }

        public void SetBitmap(Bitmap img)
        {
            if (img != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Title = "Specify a file name and file path";
                    sfd.Filter = "Jpeg Images(*.jpg)|*.jpg";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                        ImageFormat imgFormat = ImageFormat.Jpeg;
                        StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                        img.Save(streamWriter.BaseStream, imgFormat);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
            }

        }
    }
}
