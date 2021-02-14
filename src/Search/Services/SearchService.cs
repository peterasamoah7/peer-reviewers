using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Search.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Search.Services
{
    public class SearchService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration; 

        public SearchService(HttpClient httpClient, IConfiguration configuration)
        {
            ///add Azure Cognitive service base address
            httpClient.BaseAddress = new Uri(configuration["AzureCognitive:Endpoint"]);
            ///add Azure Cognitive service api key
            httpClient.DefaultRequestHeaders.Add("api-key", 
                configuration["AzureCognitive:ApiKey"]);

            _httpClient = httpClient;
            _configuration = configuration; 
        }

        /// <summary>
        /// Search and Retrieve results from Azure Cognitive Service Index
        /// </summary>
        /// <param name="searchStrs"></param>
        /// <returns></returns>
        public async Task<SearchResult> GetResultsAsync(string searchStrs)
        {
            var queryParams = HttpUtility.ParseQueryString(string.Empty);

            queryParams.Add("search", searchStrs);
            queryParams.Add("api-version", _configuration["AzureCognitive:ApiVersion"]);
            queryParams.Add("$select", "metadata_storage_name");
            
            var requestUri = $"indexes/" +
                $"{_configuration["AzureCognitive:Index"]}/" +
                $"docs?{queryParams.ToString()}";

            var response = await _httpClient.GetAsync(requestUri);

            response.EnsureSuccessStatusCode();

            var responseStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SearchResult>(responseStr); 
        }
    }
}
