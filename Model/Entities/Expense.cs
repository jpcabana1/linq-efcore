public class Expense
{
    public Guid Id { get; set; }
    public User user { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
    public string Status { get; set; }
    public bool active { get; set; }
    public DateTime DtCreated { get; set; }
    public DateTime DtUpdate { get; set; }
    
}