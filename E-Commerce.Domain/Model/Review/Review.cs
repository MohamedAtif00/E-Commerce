using E_Commerce.Domain.Common;
using E_Commerce.Domain.Model.Review.Entity;
using E_Commerce.Domain.Model.Review.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Review
{
    public class Review : AggregateRoot<ReviewId>
    {

        public Rating _rating { get; private set; }
        public CommentId _commentId { get; private set; }

        public Comment _comment { get; private set; }
        public Review(ReviewId id,Rating rating) : base(id)
        {
            Id = id;
            _rating = rating;
        }

        public static Review Create(Rating rating)
        {
            return new(ReviewId.CreateUnique(),rating);
        }

        public void Update(Rating newRating)
        {
            _rating = newRating;
        }

        public void AddComment(CommentId commentId)
        {
            _commentId = commentId;
        }



    }
}
