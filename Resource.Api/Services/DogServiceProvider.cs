using Resource.Api.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resource.Api.Services
{
    public interface IDogServiceProvider
    {
        Task<DogMessage> GetDogMessageAsync();
    }
    public class DogServiceProvider : IDogServiceProvider
    {
        private readonly HttpClient _client;

        public DogServiceProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<DogMessage> GetDogMessageAsync()
        {
            try
            {
                var url = "https://dog.ceo/api/breeds/image/random";
                var response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var result = JsonConvert.DeserializeObject<DogMessage>(await response.Content.ReadAsStringAsync());

                return result;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
