using MediatR;

namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<List<GetProductsDTO>>
    {
    }
}
