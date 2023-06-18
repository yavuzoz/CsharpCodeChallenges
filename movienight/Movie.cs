﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;

        // 1
        private bool fresh { get { return reviewScore > 75; } }

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }


        // 2
        public override string ToString()
        {
            // 3
            string description = $"-> {title} \n\tRated {rating} \n\t{reviewScore}% on RT";

            // 4
            if (fresh)
            {
                description += " - Certified Fresh!";
            }

            // 5
            return description;
        }
    }
}