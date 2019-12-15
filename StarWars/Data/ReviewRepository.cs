﻿using StarWars.Models;
using System;
using System.Collections.Generic;

namespace StarWars.Data
{
    public class ReviewRepository
    {
        private readonly Dictionary<Episode, List<Review>> _data =
            new Dictionary<Episode, List<Review>>();

        public void AddReview(Episode episode, Review review)
        {
            if (!_data.TryGetValue(episode, out var reviews))
            {
                reviews = new List<Review>();
                _data[episode] = reviews;
            }

            reviews.Add(review);
        }

        public IEnumerable<Review> GetReviews(Episode episode) => 
            _data.TryGetValue(episode, out var reviews) 
                ? (IEnumerable<Review>) reviews 
                : Array.Empty<Review>();
    }
}
