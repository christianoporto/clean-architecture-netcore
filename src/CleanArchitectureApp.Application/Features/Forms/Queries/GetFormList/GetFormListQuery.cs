using CleanArchitectureApp.Application.Dtos;
using MediatR;

namespace CleanArchitectureApp.Application.Features.Forms.Queries.GetFormList;

public record GetFormListQuery(string accountId) : IRequest<ICollection<FormDto>>;
