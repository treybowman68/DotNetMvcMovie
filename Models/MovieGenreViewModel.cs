using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    //allows the user to select a genre from the list
    public SelectList? Genres { get; set; }
    //contains the selected genre
    public string? MovieGenre { get; set; }
    // user entered text
    public string? SearchString { get; set; }
}