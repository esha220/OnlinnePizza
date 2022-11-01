using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OnlinnePizza.Models;
using OnlinnePizza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinnePizza.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<Pizza> Pizzas { get; private set; }
        public JsonPiizzaFile PizzaService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonPiizzaFile pizzaService
            )
        {
            _logger = logger;
            PizzaService = pizzaService;
        }

        public void OnGet()
        {
            Pizzas = PizzaService.getPizzaData();
        }
    }
}
