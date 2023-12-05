using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping;

internal sealed class EmployeeMapper : Profile
{
    public EmployeeMapper()
    {
        CreateMap<Employee, EmployeeModel>();
    }
}
