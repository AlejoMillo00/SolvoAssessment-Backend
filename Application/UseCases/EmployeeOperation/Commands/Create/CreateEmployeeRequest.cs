using Application.Common.Models;
using MediatR;

namespace Application.UseCases.EmployeeOperation;

public sealed class CreateEmployeeRequest : IRequest<ServiceResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
}
