using MarvelKataLibrary.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MarvelKataLibrary
{
    public class MarveApiRepository : MarvelKataLibrary.IComicsRepository
    {

        private static readonly String _timeStamp = DateTime.Now.Millisecond.ToString();
        private static readonly String _publicKey = "97f295907072a970c5df30d73d1f3816";
        private static readonly String _privateKey = "ed54a875c0dffad1fa6af84e66ff104434a1c6cc";
        private readonly String _hashApiMarvel;

        public MarveApiRepository()
        {
            _hashApiMarvel = GetMD5HashData(_timeStamp + _privateKey + _publicKey);
        }

        private string GetMD5HashData(string data)
        {
            MD5 md5 = MD5.Create();

            byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X2"));
            }

            return returnValue.ToString().ToLower();

        }
        public List<Comic> GetComicsNextWeek()
        {
            List<Comic> comicList;
            using (WebClient proxy = new WebClient())
            {

                String urlProxyMarvel = String.Format("http://gateway.marvel.com:80/v1/public/comics?{0}&ts={1}&apikey={2}&hash={3}", "dateDescriptor=nextWeek", _timeStamp, _publicKey, _hashApiMarvel);
                String response = proxy.DownloadString(urlProxyMarvel);
                JObject results = JObject.Parse(response);

                JArray resultComics = (JArray)results["data"]["results"];
                MarvelApiMapper mapper = new MarvelApiMapper();

                comicList = mapper.GetComicFromMarvelAPIData(resultComics);
                
            }
            return comicList;
        }
    }
}
