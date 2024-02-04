using E_Commerce.Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Model.SubCategory.Rule
{
    internal class NameCannotBeEmpityRule : IBusinessRule
    {
        public string Name { get;private set; }
        public string message => "The Name Field Can not be null or Empity";

        public NameCannotBeEmpityRule(string name)
        {
            Name = name;
        }
        public bool isBroken()
        {
            return string.IsNullOrEmpty(Name);
        }
    }
}
