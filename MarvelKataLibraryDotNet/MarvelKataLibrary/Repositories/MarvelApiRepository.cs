
using MarvelKataLibrary.Entities;
using MarvelKataLibrary.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MarvelKataLibrary.Repositories
{
    public class MarvelApiRepository : IComicsRepository
    {
        IMarvelApiGateway _marvelApiGateway;
        public MarvelApiRepository(IMarvelApiGateway marvelApiGateway)
        {
            _marvelApiGateway = marvelApiGateway;
        }
        
        
        public List<Comic> GetComicsNextWeek()
        {
            return _marvelApiGateway.GetComicsNextWeek();
        }
    }
}
