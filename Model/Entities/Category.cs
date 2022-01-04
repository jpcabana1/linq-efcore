public class Category
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public DateTime DtCreated { get; set; }
    public DateTime DtUpdate { get; set; }
    
}