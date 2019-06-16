using Microsoft.Extensions.Configuration;
using Mismanagement.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mismanagement.Services
{
    public class ProjectService:IProjectService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration config;
        public string projectApiUrl { get; set; }

        public ProjectService(IConfiguration config, 
            IHttpClientFactory httpClientFactory)
        {
            this.config = config;
            _httpClientFactory = httpClientFactory ??
              throw new ArgumentNullException(nameof(httpClientFactory));
        }
        public async Task<IEnumerable<Project>> GetProjects()
        {
            projectApiUrl = config["ProjectApiUrl"];
            var httpClient = _httpClientFactory.CreateClient();

            //var response = await httpClient
            //       .GetAsync($"http://localhost:62955/api/project");

            var response = await httpClient.GetAsync(projectApiUrl);

            //var c = await response.Content.ReadAsStringAsync();
            //var x = JsonConvert.DeserializeObject(c);

            var result = JsonConvert.DeserializeObject<IEnumerable<Project>>
                (await response.Content.ReadAsStringAsync());

            return result;
        }

        public Project GetProjectDetailById(int projectId)
        {
            projectApiUrl = config["ProjectDetailApiUrl"] + projectId;
            var httpClient = _httpClientFactory.CreateClient();
            var response = httpClient.GetAsync(projectApiUrl).Result;
            var result = JsonConvert.DeserializeObject<Project>(response.Content.ReadAsStringAsync().Result);
            return result;
        }
    }
}
