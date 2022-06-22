using EmployeeDetails;
using EmployeeDetails.Entities;

namespace OrganizationConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();
            Console.WriteLine("Adding a new Employee");
            obj.Insert(new Employee { Name = "Madhu", Address = "Hyderabad" });
            obj.Insert(new Employee { Name = "Rishi", Address = "Banglore" });
            PrintAllEmployees();

            Console.WriteLine("Updating Employee with EmployeeId 2");
            obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            PrintAllEmployees();

            Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            var employee = obj.GetEmplpoyeeById(2);
            Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            Console.WriteLine("Deleting Employee details for EmployeeId 2");
            obj.Delete(2);
            PrintAllEmployees();

            Console.ReadLine();

            SaveEmployee();
            Console.WriteLine("Done");
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
        private static void SaveEmployee()
        {
            CRUDEmployeeOrganization obj = new CRUDEmployeeOrganization();
            #region Save data in both the tables by Only Inserting in Education Table
            var employee = new Employee { Name = "Harini", Address = "Hyderabad" };
            List<EmployeeOrganization> organizations = new List<EmployeeOrganization>();
            organizations.Add(new EmployeeOrganization
            {
                Name = "Wipro",
                Location ="Banglore",
                Employee = employee
            });
            organizations.Add(new EmployeeOrganization
            {
                Name = "Capgemini",
                Location ="Chennai",
                Employee = employee
            });

            obj.InsertOrganisation(organizations);
            #endregion

            #region Save data in both the tables by only Inserting in Employee Table
            //List<Organization> organizations = new List<Organization>();
            organizations.Add(new EmployeeOrganization { Name = "Wipro", Location ="Banglore" });
            organizations.Add(new EmployeeOrganization { Name = "Capgemini", Location ="Chennai"});

            obj.InsertEmployeeAndOrganization(new Employee { Name = "Ravali", Address = "Delhi" }, organizations);
            #endregion

            //List<Organization> organizations = new List<Organization>();
            organizations.Add(new EmployeeOrganization { Name = "Wipro", Location ="Banglore" });
            organizations.Add(new EmployeeOrganization { Name = "Capgemini", Location ="Chennai"});

            obj.InsertEmployeeAndOrganization(new Employee { Name = "Ravali", Address = "Delhi" }, organizations);
            obj.InsertOrganizationofExistingEmployee(2, organizations);

            obj.PrintEmployeeAndOrganization(2);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

