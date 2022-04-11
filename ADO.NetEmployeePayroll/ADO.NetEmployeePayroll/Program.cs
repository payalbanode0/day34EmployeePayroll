using System;

namespace ADO.NetEmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Sql");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();


            //employee.EmployeeName = "Eren Jeager";
            //employee.PhoneNumber = "8106529025";
            //employee.Address = "25-4-710";
            //employee.Department = "Hr";
            //employee.Gender = 'M';
            //employee.BasicPay = 22000;
            //employee.Deductions = 1500;
            //employee.TaxablePay = 200.00;
            //employee.Tax = 300;
            //employee.NetPay = 25000;
            //employee.StartDate = DateTime.Now;
            //employee.City = "Kazipet";
            //employee.Country = "India";
            //UC 1
            //repo.GetAllEmployee();
            //UC 2
            //repo.AddEmployee(employee);
            //UC 3 and 4
            //repo.Update(employee);
            //UC 5
            //repo.Retrieve(employee);
            //UC 6
            //repo.Aggregate(employee);

            //UC 7
            employee.EmployeeName = "Levi Ackermen";
            employee.PhoneNumber = "8106529025";
            employee.Address = "25-4-710";
            employee.Department = "Captian";
            employee.Gender = 'M';
            employee.BasicPay = 220000;
            employee.Deductions = 1500;
            employee.TaxablePay = 2000.00;
            employee.Tax = 3000;
            employee.NetPay = 250000;
            employee.StartDate = DateTime.Now;
            employee.City = "Wall Maria";
            employee.Country = "Anime";
            repo.AddPayRollOfNewEmployee(employee);



        }
    }
}