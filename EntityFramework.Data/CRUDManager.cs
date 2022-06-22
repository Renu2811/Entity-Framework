﻿using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public  class CRUDManager
    {
        DemoDbContext demoDbContext = new DemoDbContext();
        public List<Employee> GetAllEmployees()
        {
            var employee = demoDbContext.Employees.ToList();
            return employee;
        }

        public void Insert(Employee employee)
        {
            demoDbContext.Employees.Add(employee);
            demoDbContext.SaveChanges();
        }


        public Employee GetEmplpoyeeById(int employeeId)
        {
            // Tracking not required
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (employee == null)
            {
                Console.WriteLine($"Employee with ID:{employeeId} Not Found");
            }

            return employee;
        }

        //public Employee GetEmplpoyeeById(int employeeId)
        //{
        //    // Tracking not required
        //    var employee = demoDbContext.Employees.Where(x => x.Name == "Renu")
        //                    .AsNoTracking()
        //                    .First();

        //    if (employee == null)
        //    {
        //        Console.WriteLine($"Employee with ID:{employeeId} Not Found");
        //    }

        //    return employee;
        //}

        public void Update(int employeeId, Employee modifiedEmployee)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            employee.Name = modifiedEmployee.Name;
            employee.Address = modifiedEmployee.Address;

            // Entity state : Modified
            demoDbContext.Employees.Update(employee);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void Delete(int employeeId)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.Employees.Remove(employee);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void InsertEducationDetails(EmployeeEducation employeeEducationObj)
        {
            demoDbContext.EmployeeEducations.Add(employeeEducationObj);
            demoDbContext.SaveChanges();
        }

        public void UpdateEducationDetails(int educationId, EmployeeEducation modifiedEducationDetails)
        {
            var education = demoDbContext.EmployeeEducations.Where(x => x.ID == educationId).FirstOrDefault();
            if (education == null)
            {
                throw new Exception($"Employee with ID:{educationId} Not Found");
            }

            education.CourseName = modifiedEducationDetails.CourseName;
            education.UniversityName = modifiedEducationDetails.UniversityName;
            education.PassingYear = modifiedEducationDetails.PassingYear;
            education.MarksPercentage = modifiedEducationDetails.MarksPercentage;

            // Entity state : Modified
            demoDbContext.EmployeeEducations.Update(education);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void DeleteEducationDetails(int educationId)
        {
            var employEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == educationId).FirstOrDefault();
            if (employEducation == null)
            {
                throw new Exception($"Employee with ID:{educationId} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.EmployeeEducations.Remove(employEducation);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public List<EmployeeEducation> GetAllEmployeesEducation()
        {
            var employeeEducation = demoDbContext.EmployeeEducations.ToList();
            return employeeEducation;
        }

        public EmployeeEducation GetEmployeeEducationById(int educationId)
        {
            // Tracking not required
            var education = demoDbContext.EmployeeEducations.Where(x => x.ID == educationId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (education == null)
            {
                throw new Exception($"Employee with ID:{educationId} Not Found");
            }

            return education;
        }
    }
}
    
