using System;

namespace EmployeesManagement
{
    public class Employee
    {

        private decimal _monthlySalary;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }

        public decimal MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                _monthlySalary = Validators.ValidateSalary(value);

            }
        }

        public static decimal MinimumSalary = 1000.00m;

        public Employee(string firstName, string lastName, int age, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DateOfBirth = dateOfBirth;
            MonthlySalary = MinimumSalary;
        }

        public decimal CalculateAnnualSalary()
        {
            return MonthlySalary * 12;
        }

        public void Promote(decimal percentageIncrease = 10)
        {
            MonthlySalary += MonthlySalary * (percentageIncrease / 100);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (Matrícula: {EmployeeId}) - Idade: {Age} - Salário Mensal: R${MonthlySalary:F2}";
        }
    }

}