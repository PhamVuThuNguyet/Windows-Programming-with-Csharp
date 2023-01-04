using AutomobileLibary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Cars> GetCars();
        Cars GetCarByID(int carID);
        void InsertCar(Cars car);
        void UpdateCar(Cars car);
        void DeleteCar(Cars car);
    }
}
