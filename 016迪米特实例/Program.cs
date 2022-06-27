using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016迪米特实例
{
    public class Employee
    {
        private string id;
        public void SetId(string id)
        {
            this.id = id;
        }
        public string GetId()
        {
            return this.id;
        }
    }

    public class SubEmployee
    {
        private string id;
        public void Setid(string id)
        {
            this.id = id;
        }
        public string GetId()
        {
            return this.id;
        }
    }

    public class SubCompanyManager
    {
        public List<SubEmployee> GetAllEmployee()
        {
            List<SubEmployee> list = new List<SubEmployee>();
            for (int i = 0; i < 100; i++)
            {
                SubEmployee subEmployee = new SubEmployee();
                subEmployee.Setid("分公司" + i.ToString());
                list.Add(subEmployee);
            }

            return list;
        }
        public void PrintSubEmployee()
        {
            List<SubEmployee> list = this.GetAllEmployee();
            foreach(var temp in list)
            {
                Console.WriteLine(temp.GetId());
            }
        }
    }
    public class CompanyManager
    {
        public List<Employee> GetAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < 100; i++)
            {
                Employee employee = new Employee();
                employee.SetId("总公司" + i.ToString());
                list.Add(employee);
            }
            return list;
        }
        public void PrintComEmployee(SubCompanyManager sub)
        {
            //var allSubEmployed = sub.GetAllEmployee();
            //foreach (var temp in allSubEmployed)
            //{
            //    Console.WriteLine(temp.GetId());
            //}
            sub.PrintSubEmployee();
            var allComEmployee = this.GetAllEmployee();
            foreach (var temp in allComEmployee)
            {
                Console.WriteLine(temp.GetId());
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CompanyManager companyManager = new CompanyManager();
            companyManager.PrintComEmployee(new SubCompanyManager());
            Console.ReadKey();
        }
    }
}
