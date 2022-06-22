using EmployeeDetails.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public  class CRUDEmployeeOrganization
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        public void InsertOrganisation(List<EmployeeOrganization> organizations)
        {
            demoDbContext.EmployeeOrganizations.AddRange(organizations);
            demoDbContext.SaveChanges();
        }
        public void InsertEmployeeAndOrganization(Employee employee, List<EmployeeOrganization> organizations)
        {
            var objEmployee = new Employee
            {
                Name = employee.Name,
                Address = employee.Address,
                OrganizationList = organizations

            };

            demoDbContext.Employees.Add(objEmployee);
            demoDbContext.SaveChanges();
        }
        public void InsertOrganizationofExistingEmployee(int employeeID, List<EmployeeOrganization> organizations)
        {
            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.OrganizationList).First();

            objEmployee.Name = "Ravali";

            // Do not write these 2 lines if you do not want to delete old records.
            objEmployee.OrganizationList.Clear();
            demoDbContext.SaveChanges();

            foreach (EmployeeOrganization organization in organizations)
            {
                objEmployee.OrganizationList.Add(organization);
            }

            demoDbContext.Employees.Update(objEmployee);
            demoDbContext.SaveChanges();
        }
        public void PrintEmployeeAndOrganization(int employeeID)
        {
            //var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).First();

            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.OrganizationList).First();

            Console.WriteLine($"Name of Employee is {objEmployee.Name}");

            foreach (EmployeeOrganization organization in objEmployee.OrganizationList)
            {
                Console.WriteLine($"Name of organization is {organization.Name}");
            }

        }
    }
}
    
