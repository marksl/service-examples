using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace Service
{
    public enum CarType
    {
        Basic,
        Deluxe
    }

    public partial class PurchasedCar
    {

        // This does not work. Causes cryptic error:
        // "The server encountered an error processing the request. See server logs for more details."
        //[EdmScalarProperty(EntityKeyProperty = false, IsNullable = false)]
        //[DataMember]
        //public CarType Type { get; set; }
    }
}