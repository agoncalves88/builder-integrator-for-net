using System.Net.Http.Headers;
using Builder.Integrator.For.Net.Domain.Interface.Acl;
using Newtonsoft.Json.Linq;

namespace Builder.Integrator.For.Net.Acl;
public class ApiIntegratorAcl : IApiIntegratorAcl
{
    public async Task<string> GetServiceContent(string servicePath)
    {
        using HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(servicePath);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage response = await client.GetAsync(servicePath);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        return string.Empty;
    }
}

