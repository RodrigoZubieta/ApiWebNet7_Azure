namespace WepApiNet7.Dto
{
    public class ProductDTO
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
