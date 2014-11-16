using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarvelKataLibrary.Entities;
using System.Collections.Generic;
using MarvelKataLibrary.Repositories;
using MarvelKataLibrary.Gateway;

namespace MarvelKataLibrary.UnitTest
{
    [TestClass]
    public class MarvelApiRepositoryTests
    {

        [TestMethod]
        public void GetComicsNextWeekTest()
        {
            //ARRANGE
            MarvelApiGateway marvelApiGateway = new MarvelApiGateway();

            MarvelApiRepository sut = new MarvelApiRepository(marvelApiGateway);
          
            //ACT
            List<Comic> actual = sut.GetComicsNextWeek();
            
            //ASSERT
            int numElements = actual.Count;

            Assert.IsTrue(numElements > 0, "No se han encontrado resultados.");
            Assert.AreNotEqual(0, actual[0].Price, "Primer Comic sin Price");
            Assert.AreNotEqual(String.Empty, actual[0].ThumbailUrl, "Primer Comic sin ThumbailUrl");
            Assert.AreNotEqual(String.Empty, actual[0].Title, "Primer Comic sin Title");


            Assert.AreNotEqual(0, actual[numElements - 1].Price, "Último Comic sin Price");
            Assert.AreNotEqual(String.Empty, actual[numElements - 1].ThumbailUrl, "Último Comic sin ThumbailUrl");
            Assert.AreNotEqual(String.Empty, actual[numElements - 1].Title, "Último Comic sin Title");
        }
    }
}
