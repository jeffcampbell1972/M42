﻿using System;
using System.Collections.Generic;
using System.Text;

namespace M42.Sports
{
    public class Division
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }

        public int SortOrder { get; set; }
        public List<Franchise> Franchises { get; set; }
        public List<Team> Teams { get; set; }
    }
}
