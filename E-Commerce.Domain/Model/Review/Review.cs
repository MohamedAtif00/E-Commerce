using E_Commerce.Domain.Common.Abstract;
using E_Commerce.Domain.Model.Product;
using E_Commerce.Domain.Model.Product.ValueObject;
using E_Commerce.Domain.Model.Review.Entity;
using E_Commerce.Domain.Model.Review.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Review
{
    public sealed class Review : AggregateRoot<ReviewId>
    {
        public ProductId _ProductId { get;private set; }
        public Rating _rating { get; private set; }
        public CommentId _commentId { get; private set; }

        public Comment _comment { get; private set; }
        public Review(ReviewId id,ProductId productId,Rating rating) : base(id)
        {
            _rating = rating;
            _ProductId = productId;
        }

        public static Review Create(ProductId productId,Rating rating)
        {
            return new(ReviewId.CreateUnique(),productId,rating);
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
