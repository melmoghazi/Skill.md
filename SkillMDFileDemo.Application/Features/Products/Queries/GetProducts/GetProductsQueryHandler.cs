using AutoMapper;
using MediatR;
using SkillMDFileDemo.Domain.Repositories;

namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<GetProductsDTO>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<GetProductsDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            // Map products to GetProductsDTO
            var mappedProducts = _mapper.Map<List<GetProductsDTO>>(products);
            return mappedProducts;
        }
    }
}
