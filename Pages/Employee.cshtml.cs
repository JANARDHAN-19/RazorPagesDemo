using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class EmployeeModel : PageModel
    {
        //Create a variable to hold list of Employees
        public List<Employees> EmployeeList { get; set; }

        //Constructor Taking List<Employees> as a Parameter
        public EmployeeModel(List<Employees> listOfEmployees)
        {
            EmployeeList = listOfEmployees;
            EmployeeList.Add(new Employees() { Id = 1, FirstName = "Akshay", LastName = "Kumar" });
            EmployeeList.Add(new Employees() { Id = 2, FirstName = "Aravind", LastName = "Patil" });
            EmployeeList.Add(new Employees() { Id = 3, FirstName = "Bhanu", LastName = "Prasad" });
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public void OnGet(int Id)
        {
            if (Id == 0)
            {
                this.Id = 2;
            }
        }
    }
}