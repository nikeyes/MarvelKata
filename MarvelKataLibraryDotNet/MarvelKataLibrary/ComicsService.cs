using MarvelKataLibrary.Entities;
using MarvelKataLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelKataLibrary
{
    public class ComicsService
    {
        private List<IComicsRepository> _comicsRepositoryList;
        public ComicsService()
        {
            _comicsRepositoryList = new List<IComicsRepository>();
        }

        public void AddComicRepository(IComicsRepository comicsRepository)
        {
            _comicsRepositoryList.Add(comicsRepository);
        }

        public List<Comic> GetComicsNextWeek()
        {
            List<Comic> result = new List<Comic>();
            foreach (IComicsRepository comicRepository in _comicsRepositoryList)
            {
                List<Comic> comicsNextWeek = comicRepository.GetComicsNextWeek();
                result.AddRange(comicsNextWeek);

            }
            return result;
        }
    }
}
