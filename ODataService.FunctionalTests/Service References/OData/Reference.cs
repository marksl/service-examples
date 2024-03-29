//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 8/30/2012 6:12:36 AM
namespace ODataService.FunctionalTests.OData
{
    
    /// <summary>
    /// There are no comments for Entities in the schema.
    /// </summary>
    public partial class Entities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Entities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Model", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ODataService.FunctionalTests.OData", typeName.Substring(5)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ODataService.FunctionalTests.OData", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Model.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Engines in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Engine> Engines
        {
            get
            {
                if ((this._Engines == null))
                {
                    this._Engines = base.CreateQuery<Engine>("Engines");
                }
                return this._Engines;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Engine> _Engines;
        /// <summary>
        /// There are no comments for PurchasedCars in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<PurchasedCar> PurchasedCars
        {
            get
            {
                if ((this._PurchasedCars == null))
                {
                    this._PurchasedCars = base.CreateQuery<PurchasedCar>("PurchasedCars");
                }
                return this._PurchasedCars;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<PurchasedCar> _PurchasedCars;
        /// <summary>
        /// There are no comments for TirePackages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<TirePackage> TirePackages
        {
            get
            {
                if ((this._TirePackages == null))
                {
                    this._TirePackages = base.CreateQuery<TirePackage>("TirePackages");
                }
                return this._TirePackages;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<TirePackage> _TirePackages;
        /// <summary>
        /// There are no comments for Engines in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToEngines(Engine engine)
        {
            base.AddObject("Engines", engine);
        }
        /// <summary>
        /// There are no comments for PurchasedCars in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPurchasedCars(PurchasedCar purchasedCar)
        {
            base.AddObject("PurchasedCars", purchasedCar);
        }
        /// <summary>
        /// There are no comments for TirePackages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTirePackages(TirePackage tirePackage)
        {
            base.AddObject("TirePackages", tirePackage);
        }
    }
    /// <summary>
    /// There are no comments for Model.Engine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Engines")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Engine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Engine object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="horsepower">Initial value of Horsepower.</param>
        /// <param name="cylinders">Initial value of Cylinders.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Engine CreateEngine(int ID, int horsepower, int cylinders)
        {
            Engine engine = new Engine();
            engine.Id = ID;
            engine.Horsepower = horsepower;
            engine.Cylinders = cylinders;
            return engine;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Horsepower in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Horsepower
        {
            get
            {
                return this._Horsepower;
            }
            set
            {
                this.OnHorsepowerChanging(value);
                this._Horsepower = value;
                this.OnHorsepowerChanged();
                this.OnPropertyChanged("Horsepower");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Horsepower;
        partial void OnHorsepowerChanging(int value);
        partial void OnHorsepowerChanged();
        /// <summary>
        /// There are no comments for Property Cylinders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Cylinders
        {
            get
            {
                return this._Cylinders;
            }
            set
            {
                this.OnCylindersChanging(value);
                this._Cylinders = value;
                this.OnCylindersChanged();
                this.OnPropertyChanged("Cylinders");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Cylinders;
        partial void OnCylindersChanging(int value);
        partial void OnCylindersChanged();
        /// <summary>
        /// There are no comments for PurchasedCars in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<PurchasedCar> PurchasedCars
        {
            get
            {
                return this._PurchasedCars;
            }
            set
            {
                this._PurchasedCars = value;
                this.OnPropertyChanged("PurchasedCars");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<PurchasedCar> _PurchasedCars = new global::System.Data.Services.Client.DataServiceCollection<PurchasedCar>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Model.PurchasedCar in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("PurchasedCars")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class PurchasedCar : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchasedCar object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="engineId">Initial value of EngineId.</param>
        /// <param name="tireId">Initial value of TireId.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static PurchasedCar CreatePurchasedCar(int ID, int engineId, int tireId)
        {
            PurchasedCar purchasedCar = new PurchasedCar();
            purchasedCar.Id = ID;
            purchasedCar.EngineId = engineId;
            purchasedCar.TireId = tireId;
            return purchasedCar;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CustomerName
        {
            get
            {
                return this._CustomerName;
            }
            set
            {
                this.OnCustomerNameChanging(value);
                this._CustomerName = value;
                this.OnCustomerNameChanged();
                this.OnPropertyChanged("CustomerName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CustomerName;
        partial void OnCustomerNameChanging(string value);
        partial void OnCustomerNameChanged();
        /// <summary>
        /// There are no comments for Property EngineId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int EngineId
        {
            get
            {
                return this._EngineId;
            }
            set
            {
                this.OnEngineIdChanging(value);
                this._EngineId = value;
                this.OnEngineIdChanged();
                this.OnPropertyChanged("EngineId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _EngineId;
        partial void OnEngineIdChanging(int value);
        partial void OnEngineIdChanged();
        /// <summary>
        /// There are no comments for Property TireId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int TireId
        {
            get
            {
                return this._TireId;
            }
            set
            {
                this.OnTireIdChanging(value);
                this._TireId = value;
                this.OnTireIdChanged();
                this.OnPropertyChanged("TireId");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _TireId;
        partial void OnTireIdChanging(int value);
        partial void OnTireIdChanged();
        /// <summary>
        /// There are no comments for Engine in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Engine Engine
        {
            get
            {
                return this._Engine;
            }
            set
            {
                this._Engine = value;
                this.OnPropertyChanged("Engine");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Engine _Engine;
        /// <summary>
        /// There are no comments for Tires in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public TirePackage Tires
        {
            get
            {
                return this._Tires;
            }
            set
            {
                this._Tires = value;
                this.OnPropertyChanged("Tires");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private TirePackage _Tires;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Model.TirePackage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("TirePackages")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class TirePackage : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TirePackage object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="size">Initial value of Size.</param>
        /// <param name="weight">Initial value of Weight.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static TirePackage CreateTirePackage(int ID, int size, int weight)
        {
            TirePackage tirePackage = new TirePackage();
            tirePackage.Id = ID;
            tirePackage.Size = size;
            tirePackage.Weight = weight;
            return tirePackage;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Size;
        partial void OnSizeChanging(int value);
        partial void OnSizeChanged();
        /// <summary>
        /// There are no comments for Property Weight in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this.OnWeightChanging(value);
                this._Weight = value;
                this.OnWeightChanged();
                this.OnPropertyChanged("Weight");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Weight;
        partial void OnWeightChanging(int value);
        partial void OnWeightChanged();
        /// <summary>
        /// There are no comments for PurchasedCars in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<PurchasedCar> PurchasedCars
        {
            get
            {
                return this._PurchasedCars;
            }
            set
            {
                this._PurchasedCars = value;
                this.OnPropertyChanged("PurchasedCars");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<PurchasedCar> _PurchasedCars = new global::System.Data.Services.Client.DataServiceCollection<PurchasedCar>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
