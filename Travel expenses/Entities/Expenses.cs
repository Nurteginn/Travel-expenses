
namespace Travel_expenses.Entities
{
    public class Expenses
    {
        public int Id { get; set; }
        public Trips Trip { get; set; }
        public int TripId { get; set; }
        public string Category { get; set; }
        public int Total { get; set; }
    }
}
