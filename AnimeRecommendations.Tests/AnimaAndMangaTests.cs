using AnimeRecommendations.Controllers;
using AnimeRecommendations.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace AnimeRecommendations.Tests;

public class Tests
{
    private AnimeManga _request;
    private AnimeAndMangaController _sut;

    [SetUp]
    public void Setup()
    { 
       _sut = new AnimeAndMangaController();
        _request = new AnimeManga();
    }

    [Test]
    public void when_user_creates_anime_manga_return_ok()      //200
    {
        //arrange
        _request.Title = "anime";
        _request.IsHardcopy = true;
        _request.IsManga = false;

        //act 
        ActionResult result = _sut.Create(_request);
        
        //assert 
        Assert.AreEqual(typeof(OkResult),result.GetType());
    }

    [Test]
    public void when_user_creates_animeManga_item_and_IsManga_unknown_return_bad_request()
    {
        //arrange
        _request.Title = "anime";
        _request.IsHardcopy = true;
        //act
        ActionResult result = _sut.Create(_request);
        //assert
        Assert.AreEqual(typeof(BadRequestResult),result.GetType());
    }

    [Test]
    public void when_user_creates_animeManga_item_and_title_unknown_return_bad_request()
    {
        //arrange
        _request.IsManga = true;
        _request.IsHardcopy = true;
        //act
        ActionResult result = _sut.Create(_request);
        //assert
        Assert.AreEqual(typeof(BadRequestResult),result.GetType());
    }
    
    [Test]
    public void when_user_creates_animeManga_item_with_no_hardcopy_and_no_uri_return_bad_request()
    {
        //arrange
        _request.IsManga = true;
        _request.IsHardcopy = false;
        _request.Title = "anime";
        //act
        ActionResult result = _sut.Create(_request);
        //assert
        Assert.AreEqual(typeof(BadRequestResult),result.GetType());
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