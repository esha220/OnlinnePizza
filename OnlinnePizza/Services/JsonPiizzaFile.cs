using Microsoft.AspNetCore.Hosting;
using OnlinnePizza.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OnlinnePizza.Services
{
    //for setting the value of IWebHostEnvironment
    public class JsonPiizzaFile
    {
        public JsonPiizzaFile(IWebHostEnvironment webHostEnv)
        {
            WebHostEnv = webHostEnv;
        }
        public IWebHostEnvironment WebHostEnv { get; }
        //Accessing Json file path
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnv.WebRootPath, "Data", "JSON");                                 //Generae path after combining mulltiple elements
            }
        }

        public IEnumerable<Pizza> getPizzaData()                            //Fetch Data from file 
        {
           using(var json_file = File.OpenText(JsonFilePath))
           {
             return JsonSerializer.Deserialize<Pizza[]>(json_file.ReadToEnd());
           }    
             
        }
       
       
    }
}


