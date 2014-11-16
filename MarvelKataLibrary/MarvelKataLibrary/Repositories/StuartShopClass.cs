using MarvelKataLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary
{
    /*NO PODEMOS TOCAR ESTA CLASE NI SUS MÉTODOS*/
    public class StuartShopClass
    {
         public List<Comic> GetComicsNextWeekStuartShop()
        {
            List<Comic> comics = new List<Comic>();
             /*IMPLEMENTACIÓN REAL*/

            comics.Add(new Comic()
            {
                Price = 10,
                ThumbailUrl = "http://d2lzb5v10mb0lj.cloudfront.net/covers/600/23/23596.jpg",
                Title = "Prometheus - Fire and Stone"
            });
            return comics;
        }
    }
}
