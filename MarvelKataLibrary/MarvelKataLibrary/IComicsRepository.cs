using System;
using System.Collections.Generic;
namespace MarvelKataLibrary
{
    interface IComicsRepository
    {
        List<MarvelKataLibrary.Entities.Comic> GetComicsNextWeek();
    }
}
