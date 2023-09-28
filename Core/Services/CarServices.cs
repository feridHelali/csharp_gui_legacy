using Core.Models;

namespace Core.Services
{
    public class CarServices
    {
        private readonly ISqlDataAccess db;

        public CarServices(ISqlDataAccess db)
        {
            this.db = db;
        }

        public IEnumerable<Car> GetAllCars()
        {

            return db.GetAllCars();

        }

        public Car? GetCarById(int id)
        {
            return db.GetCarById(id);
        }

        public bool DeleteCar(int id)
        {
            return db.DeleteCar(id);
        }

        public bool UpdateCar(Car car)
        {
            return db.UpdateCar(car);
        }

        public int InsertCar(Car car)
        {
            return db.InsertCar(car);
        }


    }
}
