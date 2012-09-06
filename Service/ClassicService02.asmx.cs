using System.Web.Services;
using System.Xml.Serialization;

namespace Service
{
    [WebService(Namespace = "http://service-examples02.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class ClassicService02 : WebService
    {
    [WebMethod]
    [XmlInclude(typeof(DeluxeCar))]
    public void Purchase(Car car)
    {
        PurchasedCar purchasedCar = car.ToPurchasedCar();
            
        var context = new Entities();
        context.AddToPurchasedCars(purchasedCar);
        context.SaveChanges();
    }

    public class Car
    {
        internal PurchasedCar ToPurchasedCar()
        {
            var tires = new TirePackage { Size = 16, Weight = 40 };
            var car = new PurchasedCar { CustomerName = "Me", Engine = GetEngine(), Tires = tires };

            return car;
        }

        virtual internal Engine GetEngine()
        {
            return new Engine {Cylinders = 4, Horsepower = 120};
        }
    }

    public class DeluxeCar : Car
    {
        internal override Engine GetEngine()
        {
            return new Engine {Cylinders = 8, Horsepower = 200};
        }
    }
}
}
