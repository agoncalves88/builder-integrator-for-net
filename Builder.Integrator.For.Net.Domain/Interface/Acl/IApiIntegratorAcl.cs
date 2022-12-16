using System;
namespace Builder.Integrator.For.Net.Domain.Interface.Acl
{
    public interface IApiIntegratorAcl
    {
        Task<string> GetServiceContent(string servicePath);
    }
}

