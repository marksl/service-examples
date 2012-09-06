using System;
using System.Data.Services.Client;
using NUnit.Framework;
using ODataService.FunctionalTests.OData;

namespace ODataService.FunctionalTests
{
    [TestFixture]
    public class Tests
    {
    [Test]
    [ExpectedException(typeof(DataServiceRequestException))]
    public void GoodInterface_ThrowsException()
    {
        var engine = new Engine {Cylinders = 6, Horsepower = 200};
        var tires = new TirePackage {Size = 16, Weight = 40};
        var car = new PurchasedCar {CustomerName = "Me", Engine = engine, Tires = tires};

        var context = GetEntityContext();
        context.AddToPurchasedCars(car);

        // BAD: Throws "Resource not found for the segment 'PurchasedCar'" error
        context.SaveChanges();
    }

    [Test]
    public void NonIntuitive_ButSucceeds()
    {
        var engine = new Engine { Cylinders = 6, Horsepower = 200 };
        var tires = new TirePackage { Size = 16, Weight = 40 };
        var car = new PurchasedCar { CustomerName = "Me" };

        var context = GetEntityContext();
            
        // BAD: SetLink is not type safe and has poor readability
        // Note: Order is important AddToEngines and AddToPurcasedCars must come first.
        // Note: SetLink must come after calling AddTo*() on the context
        context.AddToEngines(engine);
        context.AddToTirePackages(tires);
        context.AddToPurchasedCars(car);
        context.SetLink(car, "Engine", engine);
        context.SetLink(car, "Tires", tires);
            
        context.SaveChanges(SaveChangesOptions.Batch);
    }

        private static Entities GetEntityContext()
        {
            var serviceRoot = new Uri("http://localhost.:65191/ODataService.svc/");
            var entities = new Entities(serviceRoot);
            return entities;
        }
    }
}