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
        //200
        //arrange
        AnimeAndMangaController _sut = new AnimeAndMangaController();
       
        //act 
        string request = "test"; 
        ActionResult result = _sut.Create(request);
        
        //assert 
        Assert.AreEqual(result.GetType(),typeof(OkResult));
    }
    //400 validation
    //404 incorrect endpoint , empty body , 2 parameters and only one provided 
}