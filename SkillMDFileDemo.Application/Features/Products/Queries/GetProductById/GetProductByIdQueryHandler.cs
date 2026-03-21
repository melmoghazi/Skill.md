using AutoMapper;
using MediatR;
using SkillMDFileDemo.Domain.Repositories;

namespace SkillMDFileDemo.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdDTO>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdDTO> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product == null)
            {
                throw new InvalidOperationException($"Product with id {request.Id} not found.");
            }

            var mappedProduct = _mapper.Map<GetProductByIdDTO>(product);
            return mappedProduct;
        }
    }
}
