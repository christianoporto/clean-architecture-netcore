using MediatR;

namespace CleanArchitectureApp.Application.Features.Forms.Commands.CreateForm;

public sealed record CreateFormCommand(string id, string name) : IRequest<string>;
