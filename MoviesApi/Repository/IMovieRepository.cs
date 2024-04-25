using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repository {
    public interface IMovieRepository {
        public IEnumerable<Movie> GetAll();
        public Movie GetMovieByName(string name); 
        public void InsertMovie(Movie m);
        public void UpdateMovie(string name, Movie m);
        public void DeleteMovie(string name);
    }
}