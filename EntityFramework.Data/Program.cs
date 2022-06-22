using EntityFramework.Data;
using EntityFramework.Data.Entities;

public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Add a new employee");
        CRUDManager obj = new CRUDManager();
        //obj.Insert(new Employee { Name = "Uma", Address = "Chennai" });
        //obj.Insert(new Employee { Name = "Manohar", Address = "Banglore" });

        //PrintAllEmployees();

        //Console.WriteLine("Updating Employee with EmployeeId 2");
        //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
        //PrintAllEmployees();

        //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
        //var employee = obj.GetEmplpoyeeById(2);
        //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

        //Console.WriteLine("Deleting Employee details for EmployeeId 2");
        //obj.Delete(2);
        //PrintAllEmployees();

        //var employee = obj.GetEmplpoyeeById(20);
        //Console.WriteLine($"Employee Name is {employee.Name}");
        //Console.ReadLine();


        Console.WriteLine("Adding a new Employee Education");
       

        obj.InsertEducationDetails(new EmployeeEducation { CourseName = "IT", UniversityName = "JNTUH", PassingYear = 2019, MarksPercentage = 70 });
        obj.InsertEducationDetails(new EmployeeEducation { CourseName = "Java", UniversityName = "JNTUH", PassingYear = 2020, MarksPercentage = 87});
        PrintAllEmployeeEducation();

        Console.WriteLine("Updating Education with EducationId 2");
        obj.UpdateEducationDetails(2, new EmployeeEducation { CourseName = "BTech", UniversityName = "TNOU", PassingYear = 2018, MarksPercentage = 65});
        PrintAllEmployeeEducation();

        Console.WriteLine("Retrieving Employee Education details for eduacation Id 2");
        var education = obj.GetEmployeeEducationById(2);
        Console.WriteLine($"Employee education details of education ID 2 is {education.CourseName}");

        Console.WriteLine("Deleting Employee eduation details for Employeeeducation Id 2");
        obj.DeleteEducationDetails(2);
        PrintAllEmployeeEducation();

        Console.ReadLine();

    }

    private static void PrintAllEmployees()
    {
        Console.WriteLine("Printing all Employees");
        CRUDManager obj = new CRUDManager();
        foreach (Employee employee in obj.GetAllEmployees())
        {
            Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        }
    }

    private static void PrintAllEmployeeEducation()
    {
        Console.WriteLine("Printing all Employees Education details - ");
        CRUDManager obj = new CRUDManager();
        foreach (EmployeeEducation employeeEducation in obj.GetAllEmployeesEducation())
        {
            Console.WriteLine($"Emp CourseName is {employeeEducation.CourseName}, UniversityName is {employeeEducation.UniversityName}, PassingYear is {employeeEducation.PassingYear},MarksPercentage is {employeeEducation.MarksPercentage}");
        }
    }

}
