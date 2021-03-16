using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public enum MaturityRating { G, PG, TV_Y, TV_G, TV_PG, TV_14, TV_MA, R, NC_17, PG_13 }
    public enum Genre { Horror =1, RomCom, SciFi, Documentary, BroMance, Drama, Action, Comedy}
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public Genre GenreType { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                        return false;

                }
                return false;
                //easier way to do it using the index value from the enum               
                //if ((int)MatRating > 4)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
        }
        public StreamingContent(){}

        public StreamingContent(string title, string description,MaturityRating maturityRating, Genre genreType, double starRating )
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            GenreType = genreType;
            StarRating = starRating;


        }


    }
}
