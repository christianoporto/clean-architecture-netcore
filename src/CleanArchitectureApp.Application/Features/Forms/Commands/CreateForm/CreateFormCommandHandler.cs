using AutoMapper;
using CleanArchitectureApp.Application.Interfaces.Persistence;
using CleanArchitectureApp.Domain.Entities;
using MediatR;

namespace CleanArchitectureApp.Application.Features.Forms.Commands.CreateForm;
public class CreateFormCommandHandler : IRequestHandler<CreateFormCommand, string>
{
    private readonly IRepository<Form> _repository;
    private readonly IMapper _mapper;

    public CreateFormCommandHandler(IRepository<Form> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<string> Handle(CreateFormCommand request, CancellationToken cancellationToken)
    {
        Form form = _mapper.Map<Form>(request);
        Form result = await _repository.AddAsync(form);
        return result.Id;
    }
}