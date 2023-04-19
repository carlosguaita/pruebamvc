using System;
using pruebamvc.Models;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using Microsoft.VisualBasic;

namespace pruebamvc.Services
{
	public class ServicioApi : IServicioApi
	{

		private static string _baseUrl;

		public ServicioApi()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			_baseUrl = builder.GetSection("ApiSettings:baseUrl").Value;
		}

        public async Task<List<Producto>> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            var response = await cliente.GetAsync("/api/v1/PetShop");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                productos = resultado.listaProductos;
            }
            return productos;
        }

        public async Task<Producto> ObtenerProducto(string codigo)
        {
            Producto producto = new Producto();
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            var response = await cliente.GetAsync($"/api/v1/PetShop/{codigo}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                producto = resultado.producto;
            }
            return producto;
        }

        public async Task<string> GuardarProducto(Producto producto)
        {
            string httpsResponseCode=HttpStatusCode.BadRequest.ToString();
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8,"application/json");
            var response = await cliente.PostAsync("/api/v1/PetShop/",content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

        public async Task<string> BorrarProducto(string codigo)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            var response = await cliente.DeleteAsync($"/api/v1/PetShop/{codigo}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

        public async Task<string> EditarProducto(string codigo, Producto producto)
        {
            string httpsResponseCode = HttpStatusCode.BadRequest.ToString();
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(_baseUrl);
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await cliente.PutAsync($"/api/v1/PetShop/{codigo}", content);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<ResultadoApi>(json_response);
                httpsResponseCode = resultado.httpResponseCode;
            }
            return httpsResponseCode;
        }

     

       

        
    }
}

