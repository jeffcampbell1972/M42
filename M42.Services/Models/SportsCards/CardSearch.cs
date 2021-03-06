﻿using System;
using System.Collections.Generic;
using System.Text;

using M42.Sports;

namespace M42.SportsCards
{
    public class CardSearch
    {
        // Filter Data
        public List<int> Years { get; set; }
        public List<Person> People { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Team> Teams { get; set; }

        // Filters
        public int? Year { get; set; }
        public int? PersonId { get; set; }
        public int? SportId { get; set; }
        public bool IsRC { get; set; }
        public bool IsRelic { get; set; }
        public bool IsAutograph { get; set; }


        // Results
        public int TotalCards { get; set; }
        public int NumCards { get; set; }
        public List<Card> Cards { get; set; }

        public bool HasFilter
        {
            get 
            { 
                if (Year != null || PersonId != null)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
