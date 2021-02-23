using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ConsumeSuperHeros_Server.Models;

namespace ConsumeSuperHeros_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllHeroes("https://localhost:44382/api/SuperHeroes/get");
        }
        public static void GetAllHeroes(string url){
            using(var client=new HttpClient()){
                client.BaseAddress=new Uri(url);
                var response=client.GetAsync("");
                response.Wait();

                var result=response.Result;
                if(result.IsSuccessStatusCode){
                    var readTask=result.Content.ReadAsAsync<SuperHero[]>();
                    readTask.Wait();

                    var superHeroes=readTask.Result;

                    foreach (var superHero in superHeroes)
                    {
                        Console.WriteLine($"{superHero.id} {superHero.workName} {superHero.hideOut}");
                    }
                }
            }
        }
    }
}
