namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProducts
{
    public class GetProductsDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}