using AnimeRecommendations.Domain.Models;

namespace AnimeRecommendations.Domain.Handlers;

public interface IAnimeMangaHandler
{
    bool Add(AnimeManga animeManga);
}

public class AnimeMangaHandler : IAnimeMangaHandler
{
    public bool Add(AnimeManga animeManga)
    {
        return false;
    }
    
}





