
using Core;
using Core.Models;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private string connectionString;

        public SqlDataAccess()
        {
            connectionString = "Server=DESKTOP-1CKETIP\\MSSQLSERVER01;Database=Cars;Trusted_Connection=True"; ;
        }

        public IEnumerable<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.spCar_GetAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(new Car
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString()!,
                                Description = reader["Description"].ToString()!,
                                Price = double.Parse(reader.GetDecimal(3).ToString())


                            });
                        }
                    }
                }
                connection.Close();
                return cars;
            }
        }

        public int InsertCar(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.spCar_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", car.Name);
                    command.Parameters.AddWithValue("@Description", car.Description);
                    command.Parameters.AddWithValue("@Price", car.Price);
                    return (int) command.ExecuteNonQuery();
                }
            }

        }


        public Car? GetCarById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.spCar_GetById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Car
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString()!,
                                Description = reader["Description"].ToString()!,
                                Price = double.Parse(reader.GetDecimal(3).ToString())
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public bool DeleteCar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.spCar_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error deleting car : ${ex.Message}");
                    }
                }
            }
        }


        public bool UpdateCar(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.spCar_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", car.Id);
                    command.Parameters.AddWithValue("@Name", car.Name);
                    command.Parameters.AddWithValue("@Description", car.Description);
                    command.Parameters.AddWithValue("@Price", car.Price);

                    try
                    {
                        int rowAffected = command.ExecuteNonQuery();
                        return rowAffected > 0;

                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"Error Update Car :{ex.Message}");
                       
                    }
                }
            }
        }
    }
}
