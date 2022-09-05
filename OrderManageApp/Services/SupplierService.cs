using System.Collections;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using OrderManageApp.Models;
using System.Web.Http;

namespace OrderManageApp.Services
{
    public class SupplierService:ISupplierService
    {
        private readonly HttpClient _httpClient; 

        public SupplierService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IEnumerable<SupplierModel>> GetSuppliers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SupplierModel>>("/GetAllUsers");
        }
    }
}
