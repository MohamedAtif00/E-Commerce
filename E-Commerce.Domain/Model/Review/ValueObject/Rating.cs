using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.Review.ValueObject
{
    public sealed class Rating : Common.Abstract.ValueObject
    {
        public static Rating ZeroStar => new Rating(0m);
        public static Rating HalfStar => new Rating(0.5m);
        public static Rating OneStar => new Rating(1m);
        public static Rating OneAndHalfStar => new Rating(1.5m);
        public static Rating TwoStar => new Rating(2m);
        public static Rating TwoAndHalfStar => new Rating(2.5m);
        public static Rating ThreeStar => new Rating(3m);
        public static Rating ThreeAndHalfStar => new Rating(3.5m);
        public static Rating FourStar => new Rating(4m);
        public static Rating FourAndHalfStar => new Rating(4.5m);
        public static Rating FiveStar => new Rating(5m);


        public decimal Value { get; }
        public Rating(decimal value)
        {

            Value = value;

        }
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
