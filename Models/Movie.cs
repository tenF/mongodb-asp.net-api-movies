using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class Imdb
    {
        // if a field of the monogdb document contains key named id, we must declare _id field with the [BsonId] tag
        [BsonId]
        public string _id;
        public string id;
        public double rating { get; set; }
        public int votes { get; set; }
    }

    public class Tomato
    {
        public int meter { get; set; }
        public string image { get; set; }
        public double rating { get; set; }
        public int reviews { get; set; }
        public int fresh { get; set; }
        public string consensus { get; set; }
        public int userMeter { get; set; }
        public double userRating { get; set; }
        public int userReviews { get; set; }
    }

    public class Awards
    {
        public int wins { get; set; }
        public int nominations { get; set; }
        public string text { get; set; }
    }

    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string title;
        public int year { get; set; }
        public string rated { get; set; }
        public int runtime { get; set; }
        public List<string> countries { get; set; }
        public List<string> genres { get; set; }
        public string director { get; set; }
        public List<string> writers { get; set; }
        public List<string> actors { get; set; }
        public string plot { get; set; }
        public string poster { get; set; }
        public Imdb imdb;
        public Tomato tomato { get; set; }
        public int metacritic { get; set; }
        public Awards awards { get; set; }
        public string type { get; set; }
    }
}
