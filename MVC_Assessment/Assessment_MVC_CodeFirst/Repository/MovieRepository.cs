using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst.Models;
using System.Data.Entity;

namespace CodeFirst.Repository
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext db;
        //DbSet<T> dbset;
        public MovieRepository()
        {
            db = new MovieContext();
        }

        public void Edit(Movie movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMoviesByYear(int year)
        {
            return db.movie.Where(m => m.DateofRelease.Year == year).ToList();
        }

        public void Create(Movie movie)
        {

            db.movie.Add(movie);
            db.SaveChanges();
        }
        public IEnumerable<Movie> GetAll()
        {
            return db.movie.ToList();
        }
        public Movie GetById(int id)
        {
            return db.movie.Find(id);
        }
    }
}