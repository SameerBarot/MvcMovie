using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? genre { get; set; }
    public string? search { get; set; }
}

//namespace MvcMovie.Models
//{
  //  public class MovieGenreViewModel
    //{
    //}
//}
