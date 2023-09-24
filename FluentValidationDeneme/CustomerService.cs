using Core.Aspects.AutoFac.Validation;
using FluentValidation.Results;
using FluentValidationDeneme.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDeneme
{
    public class CustomerService
    {
        private CustomerValidator validator;

        public CustomerService()
        {
            validator = new CustomerValidator();
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public string Add(Customer customer)
        {
            return "Customer added";
        }

        public ValidationResult Validate(Customer customer)
        {
            var validationResult = validator.Validate(customer);
            return validationResult;
        }
    }
}
