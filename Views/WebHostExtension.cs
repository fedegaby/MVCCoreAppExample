using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MVCCoreAppExample;
using MVCCoreAppExample.Models;


public static class WebHostExtension
{
    public static IWebHost InitializeDB(this IWebHost webHost)
    {
        var serviceScopeFactory = (IServiceScopeFactory)webHost.Services.GetService(typeof(IServiceScopeFactory));

        using (var scope = serviceScopeFactory.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<Context>();
            
            AddTestData(context);
        }

        return webHost;
    }

    private static void AddTestData(Context context)
    {
        var customers = new List<Customer>
        {
            new Customer{FirstName = "Orlando", LastName="Gee",CompanyName="A Bike Store",EmailAddress="orlando0@adventure-works.com"},
            new Customer{FirstName = "Keith", LastName="Harris",CompanyName="Progressive Sports",EmailAddress="keith0@adventure-works.com"},
            new Customer{FirstName = "Donna", LastName="Carreras",CompanyName="Advanced Bike Components",EmailAddress="donna0@adventure-works.com"},
            new Customer{FirstName = "Janet", LastName="Gates",CompanyName="Modular Cycle Systems",EmailAddress="janet1@adventure-works.com"},
            new Customer{FirstName = "Lucy", LastName="Harrington",CompanyName="Metropolitan Sports Supply",EmailAddress="lucy0@adventure-works.com"},
            new Customer{FirstName = "Rosmarie", LastName="Carroll",CompanyName="Aerobic Exercise Company",EmailAddress="rosmarie0@adventure-works.com"},
            new Customer{FirstName = "Dominic",LastName="Gash",CompanyName="Associated Bikes",EmailAddress="dominic0@adventure-works.com"},
            new Customer{FirstName = "Kathleen",LastName="Garza",CompanyName="Rural Cycle Emporium",EmailAddress="kathleen0@adventure-works.com"},
            new Customer{FirstName = "Katherine",LastName="Harding",CompanyName="Sharp Bikes",EmailAddress="katherine0@adventure-works.com"},
            new Customer{FirstName = "Johnny",LastName="Caprio",CompanyName="Bikes and Motorbikes",EmailAddress="johnny0@adventure-works.com"},
            new Customer{FirstName = "Christopher",LastName="Beck",CompanyName="Bulk Discount Store",EmailAddress="christopher1@adventure-works.com"},
            new Customer{FirstName = "David",LastName="Liu",CompanyName="Catalog Store",EmailAddress="david20@adventure-works.com"},
            new Customer{FirstName = "John",LastName="Beaver",CompanyName="Center Cycle Shop",EmailAddress="john8@adventure-works.com"},
            new Customer{FirstName = "Jean",LastName="Handley",CompanyName="Central Discount Store",EmailAddress="jean1@adventure-works.com"},
            new Customer{FirstName = "Jinghao",LastName="Liu",CompanyName="Chic Department Stores",EmailAddress="jinghao1@adventure-works.com"},
            new Customer{FirstName = "Linda",LastName="Burnett",CompanyName="Travel Systems",EmailAddress="linda4@adventure-works.com"},
            new Customer{FirstName = "Kerim",LastName="Hanif",CompanyName="Bike World",EmailAddress="kerim0@adventure-works.com"},
            new Customer{FirstName = "Kevin",LastName="Liu",CompanyName="Eastside Department Store",EmailAddress="kevin5@adventure-works.com"},
            new Customer{FirstName = "Donald",LastName="Blanton",CompanyName="Coalition Bike Company",EmailAddress="donald0@adventure-works.com"},
            new Customer{FirstName = "Jackie",LastName="Blackwell",CompanyName="Commuter Bicycle Store",EmailAddress="jackie0@adventure-works.com"}
        };

        context.Customers.AddRange(customers);

        context.SaveChanges();
    }
}