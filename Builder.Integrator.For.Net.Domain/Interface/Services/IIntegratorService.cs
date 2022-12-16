using System;
namespace Builder.Integrator.For.Net.Domain.Interface.Services
{
	public interface IIntegratorService
	{
		public Task<string> GetDynamicServices(string group, string param);
	}
}

