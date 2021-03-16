using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
   public class StreamingRepository : StreamingContentRepository
    {
        //we will use the same _contentDirectory from StreamingContentRepository.cs
        //Read
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent  content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }

            }
            return null;

        }

        //Read -> Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
                

            }
            return null;

        }
        //Read get all
        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent  content in _contentDirectory)
            {
                if (content is Show)
                {
                    //add the show to the allShows  list
                    allShows.Add((Show)content);
                }

                

            }
            return allShows;
        }

        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }

            }
            return allMovies;
        }


    }
}
