using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null; //do not do this by habbit, training only
        }

        public StreamingContent GetContentByGenre(Genre genre)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genre)
                {
                    return content;
                }
            }
            return null; 
        }

        public StreamingContent GetContentByStarRatings(double starRatings)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == starRatings)
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByMaturityRating(MaturityRating maturityRating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == maturityRating)
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByDescription(string description)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Description == description)
                {
                    return content;
                }
            }
            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
        //get by other parameters- ratings, family friendly, etc

    }
}
