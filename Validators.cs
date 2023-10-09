using System;
using System.Globalization;

namespace EmployeesManagement
{
    public static class Validators 
    {
        public static string ValidateName(string name)
        {
            if (typeof(string) != name.GetType())
                throw new ArgumentException("O nome deve ser uma string.");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("O nome não pode ser vazio.");
         
            if (name.Trim().Length < 3)
                throw new ArgumentException("O nome deve ter pelo 3 caracteres");

            return name;
        }

        public static int ValidateAge(int age)
        {
            if (age <= 18)
                throw new ArgumentException("O funcionário deve ser maior de idade.");

            return age;
        }

        public static DateTime ValidateDateOfBirth(string dateOfBirth)
        {
            DateTime date =  DateTime.Parse(dateOfBirth, new CultureInfo("pt-BR"));

            if (typeof(DateTime) != date.GetType())
                throw new ArgumentException("A data de nascimento deve ser uma data válida.");

            if (date > DateTime.Now)
                throw new ArgumentException("A data de nascimento não pode ser no futuro.");


            return date;


        }

        public static double ValidatePercentageIncrease(double percentageIncrease)
        {
            if (percentageIncrease < 0)
                throw new ArgumentException("O percentual de aumento não pode ser negativo.");

            return percentageIncrease;
        }

        public static decimal ValidateSalary(decimal salary)
        {
            if (salary < Employee.MinimumSalary)
                throw new ArgumentException($"O salário não pode ser menor do que: {Employee.MinimumSalary}.");

            return salary;
        }

        public static int ValidateChoice(int choice)
        {
         

            
            if (choice < 1 || choice > 6)
                throw new Exception("a escolha deve ser entre 1 e 6.");

            return choice;
        }

        








    }

}