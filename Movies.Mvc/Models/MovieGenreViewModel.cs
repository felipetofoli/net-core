using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Movies.Mvc.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
    }
}