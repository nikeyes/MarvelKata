using MarvelKataLibrary.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary
{
    public class MarvelAPIMapper
    {
            public List<Comic> GetComicFromMarvelAPIData(JArray arrayMarvelJSON)
            {
                List<Comic> comicList = new List<Comic>();
                Comic comic;
                foreach (JObject resultComic in arrayMarvelJSON)
                {
                    comic = new Comic();

                    comic.Title = (String)resultComic["title"];
                    JToken thumbail = resultComic["thumbnail"];
                    comic.ThumbailUrl = thumbail["path"] + "." + thumbail["extension"];
                    comic.Price = double.Parse(resultComic["prices"][0]["price"].ToString());

                    comicList.Add(comic);
                }

                return comicList;
            }
    }
}
