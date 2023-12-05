using Api.Common;
using Application.Common.Models;
using Application.Models;
using Application.UseCases.EmployeeOperation;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class EmployeeController : ApiControllerBase
{
    /// <summary>
    /// Creates an employee
    /// </summary>
    /// <param name="body"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(ServiceResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ServiceResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ServiceResponse), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeRequest body)
    {
        return Result(await Mediator.Send(body));
    }

    /// <summary>
    /// List all employees
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(ServiceResponse<List<EmployeeModel>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ServiceResponse), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ServiceResponse), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> List()
    {
        return Result(await Mediator.Send(new ListEmployeesRequest()));
    }
}