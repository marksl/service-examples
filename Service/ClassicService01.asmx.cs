using System.Web.Services;

namespace Service
{
    [WebService(Namespace = "http://service-examples01.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class ClassicService01 : WebService
    {
    public enum CarType
    {
        Basic,
        Deluxe
    }

    [WebMethod]
    public void PurchaseCar(CarType type)
    {
        var tires = new TirePackage {Size = 16, Weight = 40};

        Engine engine = type == CarType.Basic
                            ? new Engine {Cylinders = 4, Horsepower = 120}
                            : new Engine {Cylinders = 8, Horsepower = 200};

        var car = new PurchasedCar {CustomerName = "Me", Engine = engine, Tires = tires};

        var context = new Entities();
        context.AddToPurchasedCars(car);
        context.SaveChanges();
    }
    }
}
