using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Services;

internal sealed class EmployeeCommands : IEmployeeCommands
{
    private readonly ApplicationDbContext _ctx;

    public EmployeeCommands(ApplicationDbContext ctx) 
    {
        _ctx = ctx;
    }

    public async Task<ServiceResponse> CreateAsync(Employee employee)
    {
        ServiceResponse sr = new();

        try
        {
            await _ctx.Employees.AddAsync(employee);
            await _ctx.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            sr.AddError(ex);   
        }

        return sr;
    }
}
