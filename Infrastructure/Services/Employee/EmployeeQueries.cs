using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

internal sealed class EmployeeQueries : IEmployeeQueries
{
    private readonly ApplicationDbContext _ctx;

    public EmployeeQueries(ApplicationDbContext ctx) 
    {
        _ctx = ctx;
    }

    public async Task<ServiceResponse<List<Employee>>> ListAsync()
    {
        ServiceResponse<List<Employee>> sr = new();

        try
        {
            sr.Content = await _ctx.Employees.ToListAsync();
        }
        catch (Exception ex)
        {
            sr.AddError(ex);   
        }

        return sr;
    }
}
