using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category with valid state")]
        public void CreateCategory_WhithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<DomainExecptionValidation>();
        }


        [Fact(DisplayName = "Create Category with Id invalid")]
        public void CreateCategory_NegativeIdValue_DomainExecptionValidation()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<DomainExecptionValidation>().WithMessage("Id invalid");
        }

        [Fact(DisplayName = "Create Category with short Name")]
        public void CreateCategory_ShortName_DomainExecptionValidation()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<DomainExecptionValidation>().WithMessage("Name is too short. minimum 3 character");
        }

        [Fact(DisplayName = "Create Category withou name")]
        public void CreateCategory_whithoutName_DomainExecptionValidation()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<DomainExecptionValidation>().WithMessage("Name is invalid. name is required");
        }
    }
}
