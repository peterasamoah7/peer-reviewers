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
    public class KeyPhraseService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService; 

        public KeyPhraseService(
            HttpClient httpClient, 
            IConfiguration configuration, 
            TokenService tokenService
        )
        {
            httpClient.BaseAddress = new Uri(configuration["ExpertAi:Endpoint"]);

            _httpClient = httpClient;
            _configuration = configuration;
            _tokenService = tokenService; 
        }
     
        /// <summary>
        /// Get KeyPhrase Analysis from Expert AI API
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<KeyPhraseReponse> GetKeyPhrasesAsync(
            string text, AuthenticationHeaderValue authHeader
            )
        {
            var request = new KeyPhraseRequest
            {
                Document = new Document
                {
                    Text = text
                }
            };
        
            _httpClient.DefaultRequestHeaders.Authorization = authHeader;
            var content = new StringContent(
                JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await _httpClient
                .PostAsync("v2/analyze/standard/en/relevants", content);
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<KeyPhraseReponse>(
                await response.Content.ReadAsStringAsync()); 
        }
    }
}
