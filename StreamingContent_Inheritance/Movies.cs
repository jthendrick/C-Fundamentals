﻿using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class Movie : StreamingContent
    {
        //we get all the properties from a streaming content b/c a movie "is a" streaming content
        public double RunTime { get; set; }
       
        public Movie()
        {

        }

        public Movie(string title, string description, MaturityRating maturityRating, Genre genreType, double starRating, double runTime ) 
                    :base(title,description,maturityRating,genreType,starRating,runTime)
        {
            RunTime = runTime; 
        }
    }
}
