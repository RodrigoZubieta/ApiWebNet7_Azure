namespace WepApiNet7.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
