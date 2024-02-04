using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Common.Interface
{
    internal interface IBusinessRule
    {
        bool isBroken();

        string message { get; }
    }
}
