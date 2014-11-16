using MarvelKataLibrary.Entities;
using System;
using System.Collections.Generic;
namespace MarvelKataLibrary.Gateway
{
    public interface IMarvelApiGateway
    {
        List<Comic> GetComicsNextWeek();
    }
}
