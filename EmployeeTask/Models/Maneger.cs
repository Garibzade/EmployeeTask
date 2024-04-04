namespace EmployeeTask.Models
{
    internal class Maneger:Assistant
    {
        

        internal void GetPromotion(Employee employee)
        {
            
                Console.WriteLine($"{employee.Name} premiya qazandi");
                employee.Salary += 100;
                Console.WriteLine("sizin guncel maasiniz="+employee.Salary);
            
            
            
        }
        
    }
}
