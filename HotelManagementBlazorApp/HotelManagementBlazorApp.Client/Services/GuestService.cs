using HotelManagementBlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace HotelManagementBlazorApp.Client.Services
{
    public class GuestService
    {
        private readonly HttpClient http;
        private string apiLink = "/api/RoomTypes";
        public GuestService(HttpClient http, NavigationManager nav)
        {
            http.BaseAddress = new Uri(nav.BaseUri);
            this.http = http;
        }

        public async Task<IList<RoomType>?> GetAll()
        {
            var data = await this.http.GetFromJsonAsync<IList<RoomType>>(apiLink);
            return data;
        }

        public async Task<RoomType?> GetById(int id)
        {
            return await this.http.GetFromJsonAsync<RoomType>(apiLink + $"/{id}");
        }

        public async Task<HttpResponseMessage?> Save(RoomType data)
        {
            return await this.http.PostAsJsonAsync<RoomType>(apiLink, data);
        }

        public async Task<HttpResponseMessage?> Update(RoomType data)
        {
            return await this.http.PutAsJsonAsync<RoomType>(apiLink + $"/{data.RoomTypeId}", data);
        }

        public async Task<HttpResponseMessage?> Delete(int id)
        {
            return await this.http.DeleteAsync(apiLink + $"/{id}");
        }
    }
}
