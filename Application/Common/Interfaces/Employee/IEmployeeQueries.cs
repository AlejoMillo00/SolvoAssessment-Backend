using Application.Common.Models;
using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IEmployeeQueries
{
    Task<ServiceResponse<List<Employee>>> ListAsync();
}
