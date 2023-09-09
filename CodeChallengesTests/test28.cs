using data_structures_and_algorithms.Sorting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test28
    {
        [Fact]
        public void TestSortByYear()
        {
            var movieComparators = new MovieComparators();

            // Arrange
            var movies = new List<Movie>
        {
            new Movie { Title = "Movie A", Year = 2000 },
            new Movie { Title = "Movie B", Year = 2020 },
            new Movie { Title = "Movie C", Year = 2010 }
        };

            // Act
            var sortedMovies = movieComparators.SortByYear(movies);

            // Assert
            Assert.Equal(2020, sortedMovies[0].Year);
            Assert.Equal(2010, sortedMovies[1].Year);
            Assert.Equal(2000, sortedMovies[2].Year);
        }

        [Fact]
        public void TestSortMoviesByTitle()
        {
            var movieComparators = new MovieComparators();
            // Arrange
            List<Movie> movies = new List<Movie>
    {
        new Movie { Title = "The Godfather", Year = 1972 },
        new Movie { Title = "Shawshank Redemption", Year = 1994 },
        new Movie { Title = "A Dark Knight", Year = 2008 },
        new Movie { Title = "Pulp Fiction", Year = 1994 }
    };

            // Act
            List<Movie> sortedMovies = movieComparators.SortByTitle(movies);

            // Assert
            Assert.Equal("A Dark Knight", sortedMovies[0].Title);
            Assert.Equal("The Godfather", sortedMovies[1].Title);
            Assert.Equal("Pulp Fiction", sortedMovies[2].Title);
            Assert.Equal("Shawshank Redemption", sortedMovies[3].Title);
        }


    }
}
