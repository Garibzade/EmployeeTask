using EmployeeTask.Models;

namespace EmployeeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("emil",true,770) ;
            Employee employee1 = new Employee("samir", false, 530);

            Assistant Asisitant= new Assistant();
            Asisitant.GetFeedback(employee);
            Asisitant.GetFeedback(employee1);
            

       
            
             
            
        }
    }
}
