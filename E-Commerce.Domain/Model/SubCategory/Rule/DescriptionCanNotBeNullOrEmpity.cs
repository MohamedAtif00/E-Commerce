using E_Commerce.Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.SubCategory.Rule
{
    internal class DescriptionCanNotBeNullOrEmpity : IBusinessRule
    {
        public string message => "The Description Can not be null or empity";

        public string Description { get; private set; }

        public DescriptionCanNotBeNullOrEmpity(string description)
        {
            Description = description;
        }
        public bool isBroken()
        {
            return string.IsNullOrWhiteSpace(Description.Trim());
        }
    }
}
