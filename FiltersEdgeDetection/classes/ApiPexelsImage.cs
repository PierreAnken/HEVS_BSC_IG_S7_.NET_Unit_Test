using FiltersEdgeDetection.Interfaces;
using System.Drawing;
using System.IO;

namespace FiltersEdgeDetection.classes
{
    class ApiImgurImage : IImageManager
    {
        private static readonly string CLIENTID = "ec26fa431d0e2b9";
        private static readonly string APIBASEURL = "https://api.imgur.com/3/";
        private readonly string imageHash;
        
        public ApiImgurImage(string imageHash)
        {
            this.imageHash = imageHash;
        }

        public Bitmap LoadImage()
        {
            Bitmap bitmap = null;
            string apiUrl = APIBASEURL + "image/" + imageHash;


            return bitmap;
        }

        public void SaveImage(Bitmap img)
        {

        }
    }
}
