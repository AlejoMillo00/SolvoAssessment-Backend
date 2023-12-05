using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Models;
using AutoMapper;
using MediatR;
using System.Net;

namespace Application.UseCases.EmployeeOperation;

public sealed class ListEmployeesHandler : IRequestHandler<ListEmployeesRequest, ServiceResponse<List<EmployeeModel>>>
{
    private readonly IEmployeeQueries _employeeQueries;
    private readonly IMapper _mapper;

    public ListEmployeesHandler(
        IEmployeeQueries employeeQueries,
        IMapper mapper)
    {
        _employeeQueries = employeeQueries;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<List<EmployeeModel>>> Handle(ListEmployeesRequest request, CancellationToken cancellationToken)
    {
        ServiceResponse<List<EmployeeModel>> sr = new();

        var employeesSr = await _employeeQueries.ListAsync();

        if (!employeesSr.Success)
        {
            sr.AddErrors(employeesSr.Errors);
            return sr;
        }

        sr.StatusCode = HttpStatusCode.OK;
        sr.Content = _mapper.Map<List<EmployeeModel>>(employeesSr.Content);

        return sr;
    }
}
