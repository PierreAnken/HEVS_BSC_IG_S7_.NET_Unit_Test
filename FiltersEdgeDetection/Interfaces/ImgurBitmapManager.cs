using FiltersEdgeDetection.Interfaces;
using FiltersEdgeDetection.PrensentationLayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http.Headers;

namespace FiltersEdgeDetection.classes
{
    class ImgurBitmapManager : IBitmapManager
    {
        private static readonly string CLIENTID = "ec26fa431d0e2b9";
        private static readonly string APIBASEURL = "https://api.imgur.com/3/";
        private readonly string imageHash;
        private readonly ApiForm form;
        
        public ImgurBitmapManager(string imageHash, ApiForm form)
        {
            this.imageHash = imageHash;
            this.form = form;
        }

        public Bitmap GetBitmap()
        {
            Bitmap bitmap = null;
            string apiUrl = APIBASEURL + "image/" + imageHash;
            string error = "";
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", CLIENTID);
                    var response = client.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var rawData = response.Content.ReadAsStringAsync();
                        JObject obj = JObject.Parse(rawData.Result);
                        string link = obj["data"]["link"].ToString();

                        using (var clientWeb = new System.Net.WebClient())
                        {
                            Stream stream = clientWeb.OpenRead(link);
                            bitmap = new Bitmap(stream);
                        }
                    }
                    else {
                        error = "Invalid hash";
                    }
                }
            }
            catch
            {
                error = "Unsupported image format";
            }
            form.SetErrorLabel(error);

            return bitmap;
        }

        public void SetBitmap(Bitmap img)
        {
            throw new NotImplementedException();
        }
    }
}
