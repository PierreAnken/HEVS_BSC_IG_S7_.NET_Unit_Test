using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using DAL;
using System.Drawing;
using System.IO;
using BLL;
using FiltersEdgeDetection.PrensentationLayer;

namespace TestFilterEdgeDetection
{
    [TestClass]
    public class TestImageManagement
    {
        readonly Bitmap landscapeImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"data\", "landscape.jpg"));

        [TestMethod]
        public void TestLoadImage()
        {
            var ibitmapManager = Substitute.For<IBitmapManager>();

            ibitmapManager.GetBitmap().Returns(landscapeImage);

            ImageManagement foo = new ImageManagement();
            Bitmap bitmap = foo.LoadImage(ibitmapManager, 200);

            Assert.AreEqual("95981363415123963124134142051385511793", ImageFilters.BitmapToHash(bitmap));
        }

        [TestMethod]
        public void TestSaveImage()
        {
            var ibitmapManager = Substitute.For<IBitmapManager>();

            ibitmapManager.SetBitmap(landscapeImage);

            ImageManagement foo = new ImageManagement();
            try
            {
                foo.SaveImage(ibitmapManager, landscapeImage);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

    }
}
