﻿namespace modul9_1302213026
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

      
        public Movie()
        {
            Stars = new List<string>();
        }
    }
}
