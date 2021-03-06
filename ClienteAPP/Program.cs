﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ClienteAPP
{
    class Program
    {
        static HttpClient cliente = new HttpClient();
        static void Main(string[] args)
        {

            RunAsync().Wait();

            //ShowProduct(Prod);
          
        }

        static async Task RunAsync()
        {
            try
            {
                cliente.BaseAddress = new Uri("http://localhost:50545/");
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Product Prod = new Product();
                Prod.Category = "Categoria1";
                Prod.Id = "1";
                Prod.Name = "Namaproducto";
                Prod.Price = 23;

                var url = await CreateProductAsync(Prod);

                Console.WriteLine("Created at {url}" + url);

                Console.ReadLine();
            
            
            }

            catch (Exception ex)
            {

                throw ex;
            }


           
        }

        public static void ShowProduct(Product pro) 

        {
            Console.WriteLine(JsonConvert.SerializeObject(pro));
        }
        static async Task<Uri> CreateProductAsync(Product pro)
        {


            try
            {



                HttpResponseMessage Response = await cliente.PostAsJsonAsync("api/Product", pro);
            Response.EnsureSuccessStatusCode();
            return Response.Headers.Location;
            }
          
              catch (HttpRequestException ex) { 
               throw ex;
               
              }
       
        }

     


    }
}
