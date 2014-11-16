using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarvelKataLibrary.Entities;
using System.Collections.Generic;
using MarvelKataLibrary.Repositories;
using MarvelKataLibrary.Gateway;

namespace MarvelKataLibrary.UnitTest
{
    [TestClass]
    public class ComicsServiceTests
    {

        [TestMethod]
        public void GetComicsNextWeekTest()
        {
            //ARRANGE
            MarvelApiGateway marvelApiGateway = new MarvelApiGateway();
            MarvelApiRepository marvelRepository = new MarvelApiRepository(marvelApiGateway);

            StuartShopClass claseOriginalSistema = new StuartShopClass();
            StuartShopRepository stuartRepository = new StuartShopRepository(claseOriginalSistema);

            ComicsService sut = new ComicsService();
          
            //ACT
            sut.AddComicRepository(marvelRepository);
            sut.AddComicRepository(stuartRepository);

            List<Comic> actual = sut.GetComicsNextWeek();
            
            //ASSERT
            int numElements = actual.Count;

            Assert.IsTrue(numElements > 0, "No se han encontrado resultados.");
            Assert.AreNotEqual(0, actual[0].Price, "Primer Comic sin Price");
            Assert.AreNotEqual(String.Empty, actual[0].ThumbailUrl, "Primer Comic sin ThumbailUrl");
            Assert.AreNotEqual(String.Empty, actual[0].Title, "Primer Comic sin Title");


            Assert.AreNotEqual(0, actual[numElements - 1].Price, "10");
            Assert.AreNotEqual(String.Empty, actual[numElements - 1].ThumbailUrl, "http://d2lzb5v10mb0lj.cloudfront.net/covers/600/23/23596.jpg");
            Assert.AreNotEqual(String.Empty, actual[numElements - 1].Title, "Prometheus - Fire and Stone");
        }
    }
}
