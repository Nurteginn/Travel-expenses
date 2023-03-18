namespace Travel_expenses.Entities
{
    public class Trips
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public string Destination { get; set; }
    }
}
