using MediatR;

namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<GetProductByIdDTO>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
