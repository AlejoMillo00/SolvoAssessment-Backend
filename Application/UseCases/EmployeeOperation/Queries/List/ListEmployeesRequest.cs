using Application.Common.Models;
using Application.Models;
using MediatR;

namespace Application.UseCases.EmployeeOperation;

public sealed class ListEmployeesRequest : IRequest<ServiceResponse<List<EmployeeModel>>>
{
}
