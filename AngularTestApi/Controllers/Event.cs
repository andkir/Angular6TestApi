﻿using System;

namespace AngularTestApi.Controllers
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }
        public string imageUrl { get; set; }
        public Location Location { get; set; }
        public string OnlineUrl { get; set; }
        public Session[] Sessions { get; set; }
    }

    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Presenter { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public string Abstract { get; set; }
        public string[] Voters { get; set; }
    }

    public class Location
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}