using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples
{
    public interface ICar
    {
        void Drive();
        void CheckTierPressure();        
    }
    public interface IGassCar : ICar
    {
        void FillGass();
    }
    public interface IFuelCar : ICar
    {
        void FillFuel();
    }
    public interface IBatteryCar : ICar
    {
        void ChargeBattery();
    }
    public class GassCar : IGassCar
    {
        public void CheckTierPressure()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void FillGass()
        {
            throw new NotImplementedException();
        }
    }
    public class FuelCar : IFuelCar
    {
        public void CheckTierPressure()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void FillFuel()
        {
            throw new NotImplementedException();
        }
    }

    public class BatteryCar : IBatteryCar
    {
        public void ChargeBattery()
        {
            throw new NotImplementedException();
        }

        public void CheckTierPressure()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
