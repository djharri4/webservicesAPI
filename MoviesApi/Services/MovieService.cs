using System.Collections.Generic;
using MovieApi.Models;
using MovieApi.Repository;



namespace MovieApi.Services {
    public class MovieService : IMovieService {

        private IMovieRepository _repo;

        public MovieService(IMovieRepository repo) {
            _repo = repo;
        }

        public IEnumerable<Movie> GetMovies(){
            IEnumerable<Movie> myList = _repo.GetAll();
            // sort List
            return myList;
        }

        public Movie GetMovieByName(string name){
            return _repo.GetMovieByName(name);
            //format movie
        }
        public Movie GetMoviesByYear(int year){
            IEnumerable<Movie> myList = _repo.GetAll();
            foreach(Movie m in myList){
                if (m.Year == year){
                    return m;
                }
            }
            return null;
        }
        public void CreateMovie(Movie m){
            _repo.InsertMovie(m);
        }
        public void UpdateMovie(string name, Movie m){
            _repo.UpdateMovie(name, m);
        }
        public void DeleteMovie(string name){
            _repo.DeleteMovie(name);
        }
    }
}