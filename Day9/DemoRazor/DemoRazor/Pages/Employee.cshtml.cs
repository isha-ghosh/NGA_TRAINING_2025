using DemoRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazor.Pages
{
    public class Index1Model : PageModel
    {
        //public string FirstName {  get; set; }
        public List<EmployeeData> Employees { get; set; }
        public void OnGet()
        {
           // F<irstName = "Isha";
           List<EmployeeData> employees = new List<EmployeeData>();
            
            EmployeeData emp1 = new EmployeeData(1, "John", "Male", "xyz");
            EmployeeData emp2 = new EmployeeData(2, "Niti", "Female", "xyz");
            EmployeeData emp3 = new EmployeeData(3, "John", "Male", "xyz");
            EmployeeData emp4 = new EmployeeData(4, "John", "Male", "xyz");

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            Employees = employees;
        }
    }
}
