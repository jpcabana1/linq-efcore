public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public IEnumerable<ExpenseData> Expenses { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}


