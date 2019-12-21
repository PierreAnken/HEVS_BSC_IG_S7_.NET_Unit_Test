using System.Drawing;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BLL;

namespace TestFilterEdgeDetection
{
    [TestClass]
    public class TestExtBitmap
    {
        readonly Bitmap landscapeImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"data\", "landscape.jpg"));
        readonly Bitmap portraitImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"data\", "portrait.jpg"));

        [TestMethod]
        public void TestAdaptLandscapreToSquareCanvas()
        {
            int resizedWidth = 150;
            Bitmap result = ExtBitmap.AdaptToSquareCanvas(landscapeImage, resizedWidth);

            Assert.AreEqual(resizedWidth, result.Width);
        }

        [TestMethod]
        public void TestAdaptPortraitToSquareCanvas()
        {
            float ratio = (float)portraitImage.Width / (float)portraitImage.Height;

            int resizedWidth = 150;
            Bitmap result = ExtBitmap.AdaptToSquareCanvas(portraitImage, resizedWidth);

            Assert.AreEqual(resizedWidth * ratio, result.Width);
        }

        [TestMethod]
        public void TestLaplacianFilter()
        {
            Bitmap bitmap = ExtBitmap.LaplacianFilter(landscapeImage, Matrix.Laplacian3x3);

            Assert.AreEqual("1041451535886477418911310319250196227129162", ImageFilters.BitmapToHash(bitmap));
        }

        [TestMethod]
        public void TestPrewitt()
        {
            Bitmap bitmap = ExtBitmap.DoubleMatrixFilter(landscapeImage, 
                                                      Matrix.Prewitt3x3Horizontal, 
                                                      Matrix.Prewitt3x3Vertical);

            Assert.AreEqual("2171731976721719861511911514920518480137", ImageFilters.BitmapToHash(bitmap));
        }

        [TestMethod]
        public void TestKirsch()
        {
            Bitmap bitmap = ExtBitmap.DoubleMatrixFilter(landscapeImage, 
                                                      Matrix.Kirsch3x3Horizontal, 
                                                      Matrix.Kirsch3x3Vertical);

            Assert.AreEqual("1631571221215256831351544719033149197195219", ImageFilters.BitmapToHash(bitmap));
        }
    }
}
