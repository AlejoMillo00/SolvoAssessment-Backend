using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;
using System.Net;

namespace Application.UseCases.EmployeeOperation;

public sealed class CreateEmployeeHandler : IRequestHandler<CreateEmployeeRequest, ServiceResponse>
{
    private readonly IEmployeeCommands _employeeCommands;

    public CreateEmployeeHandler(IEmployeeCommands employeeCommands)
    {
        _employeeCommands = employeeCommands;
    }

    public async Task<ServiceResponse> Handle(CreateEmployeeRequest request, CancellationToken cancellationToken)
    {
        ServiceResponse sr = await _employeeCommands.CreateAsync(new Employee
        {
            Id = request.Id,
            Name = request.Name,
            DateOfBirth = request.DateOfBirth,
        });

        if (!sr.Success)
            return sr;

        sr.StatusCode = HttpStatusCode.Created;
        sr.Message = "Employee created successfully";

        return sr;
    }
}
