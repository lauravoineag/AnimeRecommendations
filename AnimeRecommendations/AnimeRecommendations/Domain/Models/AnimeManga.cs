namespace AnimeRecommendations.Domain.Models;

public class AnimeManga
{
    public bool IsManga { get;  set; }
    public bool IsHardcopy { get; set; }
    public string Uri { get; set; }
    public string Title { get; set; }
    public Genre Genre { get; set; } 
    public double Score { get; set; }
    public Demographic Demographic { get; set; }
}

public enum Genre
{
    Action, 
    Adventure, 
    Drama, 
    Sports,
    Fantasy
}
public enum Demographic
{
    Shonen,
    Shojo,
    Seinen,
    Josei,
    Kodomomuke
}

/*Shonen: Manga targeted at tween and teen boys.
Shojo: Manga targeted at tween and teen girls.
Seinen: Manga targeted at adult men (18+).
Josei: Manga targeted at adult women (18+).
Kodomomuke: Manga targeted at young children.*/