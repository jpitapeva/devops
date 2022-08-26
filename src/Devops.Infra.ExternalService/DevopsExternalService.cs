using System.Net.Http.Headers;
using Devops.Domain.Entities;
using Devops.Domain.Interfaces;
using Newtonsoft.Json;

namespace Devops.Infra.ExternalService
{
    public class DevopsExternalService : IDevopsExternalService
    {
        private readonly HttpClient _httpClient;

        public DevopsExternalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CommitEntities.Response?> ObterCommits(CommitEntities.Request request, CancellationToken cancellationToken)
        {
            var link = $"https://dev.azure.com/{request.Organizacao}/_apis/git/repositories/{request.RepositorioId}/commits?searchCriteria.fromDate={request.ApartirDe.ToString("yyyy/MM/dd HH:mm:ss")}&searchCriteria.toDate={DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss")}&searchCriteria.author={request.Autor}&searchCriteria.$top={request.ValorMaximo}";
            var client = HttpClient(request.PersonalAccessToken);

            using HttpResponseMessage response = await client.GetAsync(link);
            if (!response.IsSuccessStatusCode)
                return null;

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CommitEntities.Response>(responseString);
        }

        public async Task<ProjetosEntities.Response?> ObterProjetos(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken)
        {
            var link = $"https://dev.azure.com/{requestBase.Organizacao}/_apis/projects";
            var client = HttpClient(requestBase.PersonalAccessToken);

            using HttpResponseMessage response = await client.GetAsync(link);
            if (!response.IsSuccessStatusCode)
                return null;

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ProjetosEntities.Response>(responseString);
        }

        public async Task<RepositoriosEntities.Response?> ObterRepositorios(RequestBaseEntities.Request requestBase, CancellationToken cancellationToken)
        {
            var link = $"https://dev.azure.com/{requestBase.Organizacao}/_apis/git/repositories";
            var client = HttpClient(requestBase.PersonalAccessToken);

            using HttpResponseMessage response = await client.GetAsync(link);
            if (!response.IsSuccessStatusCode)
                return null;

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<RepositoriosEntities.Response>(responseString);
        }

        private HttpClient HttpClient(string? personalAccessToken)
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($":{personalAccessToken}")));

            return _httpClient;
        }
    }
}
