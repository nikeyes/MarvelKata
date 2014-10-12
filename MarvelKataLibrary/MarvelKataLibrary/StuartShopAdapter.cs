using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary
{
    public class StuartShopAdapter:  IComicsRepository
    {
        private readonly StuartShopClass _componenteOriginal;
        public StuartShopAdapter(StuartShopClass claseOriginal)
        {
            _componenteOriginal = claseOriginal;
        }
        public List<Entities.Comic> GetComicsNextWeek()
        {
            return _componenteOriginal.GetComicsNextWeekStuartShop();
        }
    }
}
