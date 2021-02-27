using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MicroR.MVC.Models.Dto;
using Newtonsoft.Json;

namespace MicroR.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDto transferdto)
        {
            var uri = "https://localhost:5001/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferdto),
                System.Text.Encoding.UTF8,
                "application/json");
            var response = await _apiClient.PostAsync(uri, transferContent);

            response.EnsureSuccessStatusCode();
        }
    }
}
