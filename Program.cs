using System;


namespace EmployeesManagement
{
    class Program
    {
        static void Main()
        {
            string name;
            string lastName;
            int age;
            DateTime birthDate;
            double percentIncrease;

            Company company = new Company();


            while (true)
            {
                Console.WriteLine("\nMenu do Sistema de Gerenciamento de Empresas:");
                Console.WriteLine("1. Contratar Funcionário");
                Console.WriteLine("2. Promover Funcionário");
                Console.WriteLine("3. Listar Todos os Funcionários");
                Console.WriteLine("4. Remover Funcionário");
                Console.WriteLine("5. Listar Salário Anual de um Funcionário");
                Console.WriteLine("6. Sair");
                Console.Write("Digite sua escolha: ");

                try
                {

                    int choice = Validators.ValidateChoice(int.TryParse(Console.ReadLine(), out int result) ? result : 0);

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Digite o nome do funcionário:");
                            name = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Digite o último nome do funcionário:");
                            lastName = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Informe a idade do funcionário:");
                            age = Validators.ValidateAge(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Informe a data de nascimento do funcionário:");
                            birthDate = Validators.ValidateDateOfBirth(Console.ReadLine());

                            Employee employee = new Employee(name, lastName, age, birthDate);
                            company.AddEmployee(employee);
                            break;

                        case 2:
                            Console.WriteLine("Digite o nome do funcionário:");
                            name = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Digite o último nome do funcionário:");
                            lastName = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Informe o percentual de aumento:");
                            percentIncrease = Validators.ValidatePercentageIncrease(double.Parse(Console.ReadLine()));

                            company.PromoteEmployee(name, lastName, (decimal)percentIncrease);

                            break;

                        case 3:
                            company.ListEmployees();
                            break;

                        case 4:
                            Console.WriteLine("Digite o nome do funcionário:");
                            name = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Digite o último nome do funcionário:");
                            lastName = Validators.ValidateName(Console.ReadLine());

                            company.RemoveEmployee(name, lastName);


                            break;

                        case 5:
                            Console.WriteLine("Digite o nome do funcionário:");
                            name = Validators.ValidateName(Console.ReadLine());
                            Console.WriteLine("Digite o último nome do funcionário:");
                            lastName = Validators.ValidateName(Console.ReadLine());

                            company.ListAnnualSalary(name, lastName);
                            break;

                        case 6:
                            Console.WriteLine("Saindo do sistema...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



        }
    }
}
