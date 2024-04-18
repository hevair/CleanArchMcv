using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {

            ValidateDomain(id, name, description, price, stock, image);
        }

        public void Update(int id, string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(id, name, description, price, stock, image);
            CategoryId = categoryId;
        }

        public void ValidateDomain(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExecptionValidation.When(string.IsNullOrEmpty(name), "Name is invalid. name is required");
            DomainExecptionValidation.When(string.IsNullOrEmpty(description), "Description is invalid. description is required");
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }


    }
}
