using System;
using Builder.Integrator.For.Net.CrossCutting;
using Builder.Integrator.For.Net.Domain.Interface.Acl;
using Builder.Integrator.For.Net.Domain.Interface.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace Builder.Integrator.For.Net.Domain.Services
{
    public class IntegratorService : IIntegratorService
    {
        private readonly ILogger<IntegratorService> logger;
        private readonly IOptions<DataSourceConfigOptions> dataSourceConfigOptions;
        private readonly IApiIntegratorAcl apiIntegratorAcl;

        public IntegratorService(ILogger<IntegratorService> logger, IOptions<DataSourceConfigOptions> dataSourceConfigOptions, IApiIntegratorAcl apiIntegratorAcl)
        {
            this.logger = logger;
            this.dataSourceConfigOptions = dataSourceConfigOptions;
            this.apiIntegratorAcl = apiIntegratorAcl;
        }
        public async Task<string> GetDynamicServices(string group, string param)
        {

            var teste = dataSourceConfigOptions.Value.DATASOURCES[1];
            var result = await apiIntegratorAcl.GetServiceContent(string.Format(teste.URL, param));
            var teste2 = JObject.Parse(result)[teste.PROPERTIES_TO_GET.First().VALUE_TO_GET].ToString();
            logger.LogInformation("deu tudo certo aqui");
            return "ok";
        }
    }
}

