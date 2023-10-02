namespace management.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Juan", LastName = "Lopez" });
            employees.Add(new Employee { FirstName = "Maria", LastName = "Hernandez" });
            return employees;
        }*/
    }
}
