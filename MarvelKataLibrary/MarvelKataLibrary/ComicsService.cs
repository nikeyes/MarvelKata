using MarvelKataLibrary.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MarvelKataLibrary
{
    public class ComicsService
    {
        public Comic GetComic(String title)
        {
            Comic comic = new Comic();
            using (WebClient proxy = new WebClient())
            {
                title = HttpUtility.UrlEncode(title);
                String response = proxy.DownloadString("http://gateway.marvel.com:80/v1/public/comics?titleStartsWith=" + title + "&ts=987&apikey=97f295907072a970c5df30d73d1f3816&hash=abfa1c1d42a73a5eab042242335d805d");
                JObject results = JObject.Parse(response);

                comic.Title = (String)results["data"]["results"][0]["title"];
                JToken thumbail = results["data"]["results"][0]["thumbnail"];
                comic.ThumbailUrl = thumbail["path"] + "." + thumbail["extension"];
                comic.Price = double.Parse(results["data"]["results"][0]["prices"][0]["price"].ToString());
            } 
            return comic;
        }
    }
}
