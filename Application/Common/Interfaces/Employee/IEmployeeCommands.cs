using Application.Common.Models;
using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IEmployeeCommands
{
    Task<ServiceResponse> CreateAsync(Employee employee);
}
