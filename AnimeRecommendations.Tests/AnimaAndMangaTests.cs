using AnimeRecommendations.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace AnimeRecommendations.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    { 
    }

    [Test]
    public void create_anime_manga()
    { 
        //arrange
        AnimeAndMangaController _sut = new AnimeAndMangaController();
       
        //act 
        string request = "test"; 
        ActionResult result = _sut.Create(request);
        
        //assert 
        Assert.AreEqual(result.GetType(),typeof(OkResult));
    }
}