namespace Model;
public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; }
    public List<ExpenseData> Expenses { get; set; }
    public List<Category> Categories { get; set; }
}


