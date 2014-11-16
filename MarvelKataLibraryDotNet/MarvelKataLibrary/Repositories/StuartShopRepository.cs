using MarvelKataLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary.Repositories
{
    /*RECUBRIMOS LA CLASE ACTUAL PARA ADAPTARLA AL ComicRepository*/
    public class StuartShopRepository:  IComicsRepository
    {
        private readonly StuartShopClass _componenteOriginal;
        public StuartShopRepository(StuartShopClass claseOriginal)
        {
            _componenteOriginal = claseOriginal;
        }
        public List<Comic> GetComicsNextWeek()
        {
            return _componenteOriginal.GetComicsNextWeekStuartShop();
        }
    }
}
