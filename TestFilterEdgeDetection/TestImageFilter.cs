using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace TestFilterEdgeDetection
{
    [TestClass]
    public class TestImageFilter
    {
        readonly Bitmap landscapeImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"data\", "landscape.jpg"));

        [TestMethod]
        public void TestGetColorFromBuffer()
        {
            BitmapData bitmapData = landscapeImage.LockBits(new Rectangle(0, 0, landscapeImage.Width, landscapeImage.Height), 
                                                            ImageLockMode.ReadWrite,
                                                            landscapeImage.PixelFormat);

            byte[] pixelBuffer = new byte[bitmapData.Stride * bitmapData.Height];
            Marshal.Copy(bitmapData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            Color pixelColor = ImageFilters.GetColorFromBuffer(pixelBuffer, 1400);

            Assert.AreEqual(pixelColor, Color.FromArgb(22, 31, 38, 43));
        }

        [TestMethod]
        public void TestSetPixel()
        {
            BitmapData bitmapData = landscapeImage.LockBits(new Rectangle(0, 0, landscapeImage.Width, landscapeImage.Height), 
                                                            ImageLockMode.ReadWrite,
                                                            landscapeImage.PixelFormat);

            byte[] pixelBuffer = new byte[bitmapData.Stride * bitmapData.Height];
            Marshal.Copy(bitmapData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            Color testColor = Color.FromArgb(255, 128, 24, 128);
            ImageFilters.SetPixel(pixelBuffer, 0, testColor);

            Marshal.Copy(pixelBuffer, 0, bitmapData.Scan0, pixelBuffer.Length);
            landscapeImage.UnlockBits(bitmapData);

            Color realColor = landscapeImage.GetPixel(0, 0);
            Assert.AreEqual(testColor, realColor);
        }

        //simulate image from 12 x 12 pixels divided in 9
        [TestMethod]
        public void TestGetAreaError()
        {
            String error = "";
            try
            {
                ImageFilters.GetArea(20, 11, 4, 4);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            Assert.AreEqual(error, "Unable to find area from pixel x/y: 20/11");
        }

        [TestMethod]
        public void TestBitmapToByteArray()
        {
            BitmapData bitmapData = new BitmapData();
            byte[] pixelBuffer = ImageFilters.BitmapToByteArray(landscapeImage, ref bitmapData);

            Assert.AreEqual(pixelBuffer[50], 64);
        }

        [TestMethod]
        public void TestApplyFilterMagicMosaic()
        {
            Bitmap bitmapImage = ImageFilters.ApplyFilterMagicMosaic(landscapeImage);

            Assert.AreEqual(ImageFilters.BitmapToHash(bitmapImage), "101177507524714316166112214483255124253217");
        }

        [TestMethod]
        public void TestApplyFilterCrazy()
        {
            Bitmap bitmap = ImageFilters.ApplyFilterCrazy(landscapeImage);

            Assert.AreEqual(ImageFilters.BitmapToHash(bitmap), "228771152212037619721180133248342552710498");
        }

        [TestMethod]
        public void TestBitmapToHash()
        {
            Assert.AreEqual(ImageFilters.BitmapToHash(landscapeImage), "1961923113623723724724243216228356725025");
        }
    }
}
