using Builder.Integrator.For.Net.CrossCutting;
using Builder.Integrator.For.Net.Domain.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Builder.Integrator.For.Net.WebApi.Controllers;

[ApiController]
[Route("integrator")]
public class IntegratorController : ControllerBase
{
    private readonly ILogger<IntegratorController> _logger;
    private readonly IIntegratorService _integratorService;
    private readonly IOptions<DataSourceConfigOptions> dataSourceConfigOptions;

    public IntegratorController(ILogger<IntegratorController> logger, IIntegratorService integratorService, IOptions<DataSourceConfigOptions> dataSourceConfigOptions)
    {
        _logger = logger;
        _integratorService = integratorService;
        this.dataSourceConfigOptions = dataSourceConfigOptions;
    }


    [HttpGet, Route("group/{group}/param/{param}")]
    public async Task<IActionResult> GetIntegrator([FromRoute] string group, [FromRoute] string param)
    {
        await _integratorService.GetDynamicServices(group, param);
        return Ok("OK");
    }
}
