using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;       //Think of Entity as the models that get stored in the Database
using System.Linq;
using System.Web;

namespace RestaurantRater.Models        //Model: a class that will be passed between controllers and views
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestaurantDbContext : DbContext        //this could be placed in its own class
    {
        public DbSet<Restaurant> Restaurants { get; set; }      //I want a new collection of Restaurant Objects, called Restaurants
    }
}