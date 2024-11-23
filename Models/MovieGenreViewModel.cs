using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models;

public class MovieGenreViewModel {
    public List <Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; } //moze uzytkownik wybrac zl list gatunek
    public string? MovieGenre { get; set; } // wybrany gatunek
    public string? SearchString { get; set; } // tekst wprowadzany przez uzytkownikow
}