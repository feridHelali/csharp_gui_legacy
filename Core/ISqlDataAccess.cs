using Core.Models;

namespace Core;

public interface ISqlDataAccess
{
    bool DeleteCar(int id);
    IEnumerable<Car> GetAllCars();
    Car? GetCarById(int id);
    int InsertCar(Car car);
    bool UpdateCar(Car car);
}