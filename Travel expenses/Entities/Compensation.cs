namespace Travel_expenses.Entities
{
    public class Compensation
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Trips Trip { get; set; }
        public int TripId { get; set; }
        public int Total { get; set; }
    }
}
