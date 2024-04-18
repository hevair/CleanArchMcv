using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : EntityBase
    {
        public string Name { get; private set; }

        public ICollection<Product> products { get; set; }

        public Category(string name)
        {
            ValidateDomain(name);
            
        }

        public Category(int id, string name)
        {
            DomainExecptionValidation.When(id < 0, "Id invalid");
            Id = id;
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExecptionValidation.When(string.IsNullOrEmpty(name), "Name is invalid. name is required");
            DomainExecptionValidation.When(name.Length < 3, "Name is too short. minimum 3 character");

            Name = name;
        }
    }
}
