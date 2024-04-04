namespace EmployeeTask.Models
{
    internal class Assistant
    {
        public void GetFeedback(Employee employee)
        {
            if(employee.IsSuccessful)
            {
                Maneger maneger=new Maneger();
                maneger.GetPromotion(employee);
            }
            else { Console.WriteLine("siz bu ay yaxsi isdemeisiz="+employee.Salary); }
        }
    }
}
