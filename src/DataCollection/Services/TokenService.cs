using DataCollection.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection.Services
{
    public class TokenService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public TokenService(HttpClient httpClient, IConfiguration configuration)
        {
            httpClient.BaseAddress = new Uri(configuration["ExpertAi:AuthUrl"]);
            _httpClient = httpClient;
            _configuration = configuration;
        }

        /// <summary>
        /// Get authentication token
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<AuthenticationHeaderValue> GetAuthTokenAsync()
        {
            var request = new TokenRequest
            {
                Username = _configuration["ExpertAi:Username"],
                Password = _configuration["ExpertAi:Password"],
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await _httpClient
                .PostAsync("oauth2/token", content);
            response.EnsureSuccessStatusCode();

            return new AuthenticationHeaderValue("Bearer",
                await response.Content.ReadAsStringAsync());
        }
    }
}
