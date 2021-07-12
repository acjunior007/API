using Application.CustomExceptions;
using Domain.Interfaces;
using Domain.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CustomServices : ICustomService
    {
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _optionsClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CustomServices> _logger;

        public string UrlVindiBase { get; set; }
        public string userNameVindi { get; set; }
        public string passwordVindi { get; set; }

        public CustomServices(
            IConfiguration configuration,
            ILogger<CustomServices> logger)
        {
            _configuration = configuration;
            _logger = logger;

            this.userNameVindi = _configuration["Vindi:userNameVindi"];
            this.passwordVindi = _configuration["Vindi:passwordVind"];

            _client = new HttpClient(
                new HttpClientHandler
                {
                    AutomaticDecompression =
                                                DecompressionMethods.Deflate | DecompressionMethods.GZip,
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
                }
            )
            {
                BaseAddress = new Uri(configuration.GetSection("Vindi:URLVindi").Value)
            };
            _optionsClient = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = false
            };

            byte[] bite = Encoding.UTF8.GetBytes(this.userNameVindi + ":" + this.passwordVindi);
            string base64 = Convert.ToBase64String(bite);

            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + base64);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> DeleteAsync<T>(string endpoint)
        {
            var httpResponse = await _client.DeleteAsync($"{endpoint.ToLower()}");
            string response = await httpResponse.Content.ReadAsStringAsync();
            if (!httpResponse.IsSuccessStatusCode)
            {
                _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");
                var res = JsonSerializer.Deserialize<ResponseError>(response, _optionsClient);
                throw new Exception(res.Message);
            }

            _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");
            return JsonSerializer.Deserialize<T>(response, _optionsClient);
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var httpResponse = await _client.GetAsync($"{endpoint.ToLower()}");
            string response = await httpResponse.Content.ReadAsStringAsync();
            if (!httpResponse.IsSuccessStatusCode)
            {
                _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");
                var res = JsonSerializer.Deserialize<ResponseError>(response, _optionsClient);
                throw new Exception(res.Message);
            }

            _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");

            return JsonSerializer.Deserialize<T>(response, _optionsClient);
        }

        public async Task<T> PostAsync<T>(string endpoint, object request) where T : class
        {
            var jsonContent = JsonSerializer.Serialize(request);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var httpResponse = await _client.PostAsync(endpoint.ToLower(), contentString);
            string response = await httpResponse.Content.ReadAsStringAsync();
            if (!httpResponse.IsSuccessStatusCode)
            {
                _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");
                var res = JsonSerializer.Deserialize<Error>(response, _optionsClient);
                if (httpResponse.StatusCode == HttpStatusCode.UnprocessableEntity)
                    throw new UnprocessableException(response);
                else
                    throw new Exception(response);
            }

            _logger.LogInformation($"StatusCode [ {httpResponse.StatusCode} ] \n {response}");
            return JsonSerializer.Deserialize<T>(response, _optionsClient);
        }
    }
}