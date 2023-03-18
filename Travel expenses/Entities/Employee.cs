namespace Travel_expenses.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Full_Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public List<Compensation> Compensations { get; set }
        public List<Trips> Trips { get; set; }
    }
}
