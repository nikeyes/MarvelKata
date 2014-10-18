using System;
using System.Collections.Generic;
namespace MarvelKataLibrary
{
    public interface IComicsRepository
    {
        List<MarvelKataLibrary.Entities.Comic> GetComicsNextWeek();
    }
}
