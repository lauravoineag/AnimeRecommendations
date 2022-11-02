using AnimeRecommendations.Controllers;
using AnimeRecommendations.Domain.Models;
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
        AnimeManga request = new AnimeManga();
        request.Title = "anime";
        request.IsHardcopy = true;

        //act 
        ActionResult result = _sut.Create(request);
        
        //assert 
        Assert.AreEqual(result.GetType(),typeof(OkResult));
    }
    
    /*[Test]
    public void when_calling_create_and_no_data_is_passed_in()
    { 
        //404 incorrect endpoint , empty body , 2 parameters and only one provided 
        //arrange
        AnimeAndMangaController _sut = new AnimeAndMangaController();
        AnimeManga request = new AnimeManga();

        //act 
        ActionResult result = _sut.Create(null);
        
        //assert 
        Assert.AreEqual(result.GetType(),typeof(OkResult));
    }*/
    
    /*{
        "isManga": true,
        "isHardcopy": true,
        "uri": "string",
        "title": "string",
        "genre": 0,
        "score": 0,
        "demographic": 0
    }*/
    
    //400 validation
}