namespace design_patterns.Creational.AbstractFactory
{
    public class TataCar : ICar
    {
        public void Manufactaring()
        {
            
        }
    }

    public class TataByke : IByke
    {
        public void Manufactaring()
        {
            
        }
    }

    public class TeslaCar : ICar
    {
        public void Manufactaring()
        {

        }
    }

    public class TeslaByke : IByke
    {
        public void Manufactaring()
        {

        }
    }

    /// <summary>
    /// This is a abstract factory wich will return factory of similar  objects.
    /// </summary>
    public abstract class VehicleCompany
    {
        public abstract ICar GetCar();
        public abstract IByke GetByke();
    }

    /// <summary>
    /// This is factory of similar object which will actually create the objects
    /// </summary>
    public class TeslaCompany : VehicleCompany
    {
        public override IByke GetByke() => new TeslaByke();

        public override ICar GetCar() => new TeslaCar();
    }

    /// <summary>
    /// This is factory of similar object which will actually create the objects
    /// </summary>
    public class TataCompany : VehicleCompany
    {
        public override IByke GetByke() => new TataByke();

        public override ICar GetCar() => new TataCar();
    }
    
    /// <summary>
    /// Client Section
    /// </summary>
    //class Program
    //{ 
    //    static void Main(string[] args)
    //    {
    //        VehicleCompany teslaCompany = new TeslaCompany();
    //        IByke teslaByke = teslaCompany.GetByke();
    //        ICar teslaCar = teslaCompany.GetCar();

    //        VehicleCompany tataCompany = new TataCompany();
    //        IByke tataByke = tataCompany.GetByke();
    //        ICar tataCar = tataCompany.GetCar();
    //    }
    //}
}
