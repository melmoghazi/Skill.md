namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}
