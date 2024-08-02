using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Aled.OpenFoodFactService.Entities.Products;
using Microsoft.Extensions.Configuration;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Aled.OpenFoodFactService.Services;

public class OpenFoodFactRestService : DomainService
{
    private readonly IConfiguration _configuration;
    private readonly IHttpClientFactory _httpClient;

    public OpenFoodFactRestService(IHttpClientFactory httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<Product?> GetProductDetailAsync(string code)
    {
        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            $"{_configuration["OpenFoodFactService:Url"]}/{code}.json");

        var httpClient = _httpClient.CreateClient();

        var response = await httpClient.SendAsync(httpRequestMessage);

        if (!response.IsSuccessStatusCode)
        {
            throw new BusinessException("Failed to get product detail from OpenFoodFact service.");
        }

        return JsonSerializer.Deserialize<Product>(await response.Content.ReadAsStringAsync());
    }
}