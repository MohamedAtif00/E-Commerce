using E_Commerce.Domain.Common.Abstract;
using E_Commerce.Domain.Model.Review.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Review.Entity
{
    public class Comment : AggregateRoot<CommentId>
    {
        public string _message {  get;private set; }
        public ReviewId _reviewId { get;private set; }
        public Comment(CommentId id, ReviewId reviewId, string message) : base(id)
        {
            Id = id;
            this._reviewId = reviewId;
            _message = message;
        }

        public static Comment Creat(ReviewId reviewId,string CommentMessage)
        {
            return new(CommentId.CreateUnique(), reviewId,CommentMessage);
        }

        public void Update(string newMessage)
        {
            this._message = newMessage;
        }


    }
}
