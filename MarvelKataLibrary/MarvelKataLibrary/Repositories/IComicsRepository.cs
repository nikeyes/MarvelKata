using MarvelKataLibrary.Entities;
using System;
using System.Collections.Generic;
namespace MarvelKataLibrary.Repositories
{
    public interface IComicsRepository
    {
        List<Comic> GetComicsNextWeek();
    }
}
