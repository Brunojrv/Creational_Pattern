using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacionais.Builder
{
    public class Contract
    {
        public string SocialName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
      
        public Contract()
        {

        }

        private Contract _contractModel;

        public Contract Start()
        {
           return _contractModel = new Contract();
        }

        public Contract WithSocialName(string socialName, string FistName, string phoneNumber)
        {
            _contractModel.SocialName = socialName;
            _contractModel.FirstName = FistName;
            _contractModel.PhoneNumber = phoneNumber;
            return _contractModel;
        }

        public Contract WithAge(int age)
        {
            _contractModel.Age = age;
            return _contractModel;
        }

        public Contract Active(bool isActive)
        {
            _contractModel.IsActive = isActive;
            return _contractModel;
        }

        public Contract SalaryModel(decimal salary)
        {
            _contractModel.Salary = salary;
            return _contractModel;
        }

        public Contract StartDateModel(DateTime startDate)
        {
            _contractModel.StartDate = startDate;
            return _contractModel;
        }

        public Contract Build()
        {
            return _contractModel;
        }
    }
}
