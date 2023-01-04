using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibary.DataAccess;
using AutomobileLibary.Repository;

namespace AutomobileLibary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Cars GetCarByID(int carID) => CarManagement.Instance.GetCarByID(carID);
        public IEnumerable<Cars> GetCars() => CarManagement.Instance.getCarList();
        public void InsertCar(Cars car) => CarManagement.Instance.addNew(car);
        public void DeleteCar(Cars car) => CarManagement.Instance.Remove(car);
        public void UpdateCar(Cars car) => CarManagement.Instance.Update(car);


    }
}
