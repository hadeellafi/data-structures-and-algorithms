using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.Sorting
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Genres { get; set; }
    }
    public class MovieComparators
    {
        public List<Movie> SortByYear(List<Movie> movies)
        {
            return movies.OrderByDescending(movie => movie.Year).ToList();
        }
        public List<Movie> SortByTitle(List<Movie> movies)
        {
            return movies.OrderBy(movie => RemoveLeadingArticles(movie.Title)).ToList();
        }

        public string RemoveLeadingArticles(string title)
        {
            string[] articles = { "A", "An", "The" };
            string newTitle = title.Trim();

            foreach (var article in articles)
            {
                if (newTitle.StartsWith(article, StringComparison.OrdinalIgnoreCase))
                {
                    newTitle = newTitle.Substring(article.Length).Trim();
                    break;
                }
            }
            return newTitle;

        }



    }
}
