using MarvelKataLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary
{
    public class MarvelApiService
    {
        private IComicsRepository _comicsRepository;
        public MarvelApiService(IComicsRepository comicsRepository)
        {
            _comicsRepository = comicsRepository;
        }

        public List<Comic> GetComicsNextWeek()
        {
            return _comicsRepository.GetComicsNextWeek();
        }
    }
}
