using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData{ 
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            { 
                new Restaurant { Id = 1, Cuisine = CuisineType.Italian, Name = "Scott's Pizza"},
                new Restaurant { Id = 2, Cuisine = CuisineType.French, Name = "Percis" },
                new Restaurant { Id = 3, Cuisine = CuisineType.Indian, Name = "Punjabi house" }
            };
        }
        public IEnumerable<Restaurant> GetAll(){
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
