using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class DepartmentService:IDepartmentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration config;
        public string DepartmentApiUrl { get; set; }

        public DepartmentService(IConfiguration config,
            IHttpClientFactory httpClientFactory)
        {
            this.config = config;
            _httpClientFactory = httpClientFactory ??
              throw new ArgumentNullException(nameof(httpClientFactory));
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            DepartmentApiUrl = config["DepartmentApiUrl"];
            var httpClient = _httpClientFactory.CreateClient();

            var response =  httpClient.GetAsync(DepartmentApiUrl).Result;

            var result = JsonConvert.DeserializeObject<IEnumerable<Department>>
                ( response.Content.ReadAsStringAsync().Result);

            return result;
        }
        public IEnumerable<SelectListItem> PopulateDepartmentList()
        {
            var departments = GetAllDepartments();
            var departmentList = new List<SelectListItem>();
            foreach (var item in departments)
            {
                var dept = new SelectListItem()
                {
                    Value = item.DepartmentId.ToString(),
                    Text = item.Name
                };
                departmentList.Add(dept);
               
            }
            departmentList.Insert(0, new SelectListItem()
            {
                Value = "0",
                Text = "--- select department ---"
            });
            return new SelectList(departmentList, "Value", "Text");
        }
    }
}
