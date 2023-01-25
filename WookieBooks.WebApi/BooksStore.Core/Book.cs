﻿using MongoDB.Bson.Serialization.Attributes;
//using System;

namespace BooksStore.Core
{
   public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }
        public string CoverImage { get; set; }
        public string Price { get; set; }
    }
}
