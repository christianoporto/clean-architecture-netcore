using AutoMapper;
using CleanArchitectureApp.Application.Dtos;
using CleanArchitectureApp.Application.Interfaces.Persistence;
using CleanArchitectureApp.Domain.Entities;
using MediatR;

namespace CleanArchitectureApp.Application.Features.Forms.Queries.GetFormList;

public class GetFormListQueryHandler : IRequestHandler<GetFormListQuery, ICollection<FormDto>>
{
    private readonly IRepository<Form> _repository;
    private readonly IMapper _mapper;

    public GetFormListQueryHandler(IRepository<Form> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ICollection<FormDto>> Handle(GetFormListQuery request, CancellationToken cancellationToken)
    {
        ICollection<Form> result = await _repository.GetListAsync(request.accountId);
        ICollection<FormDto> resultDto = _mapper.Map<ICollection<FormDto>>(result);
        return resultDto;
    }
}