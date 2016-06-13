using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieIMDbRatingViewModel
    {
        public List<Movie> movies;
        public SelectList IMDbRating;
        public decimal movieIMDbRating { get; set; }
    }
}
