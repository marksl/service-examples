using System.Data.Services;
using System.Data.Services.Common;

namespace Service
{
    public class ODataService : DataService<Entities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Engines", EntitySetRights.All);
            config.SetEntitySetAccessRule("TirePackages", EntitySetRights.All);
            config.SetEntitySetAccessRule("PurchasedCars", EntitySetRights.All);

            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
            config.UseVerboseErrors = true;
        }
    }
}
