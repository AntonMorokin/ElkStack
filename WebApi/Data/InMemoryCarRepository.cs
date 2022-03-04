using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Data
{
    internal sealed class InMemoryCarRepository : ICarRepository
    {
        private readonly IList<Car> _data = new List<Car>
        {
            new Car
            {
                Id = 1,
                Number = "XYZ123",
                OwnerName = "Alyosha",
                Model = "Tiguan",
                Color = "Black"
            },
            new Car
            {
                Id = 4,
                Number = "FG8659Y",
                OwnerName = "Vanya",
                Model = "Oktavia",
                Color = "White"
            }
        };

        public Task<Car> GetCarByIdAsync(int carId)
        {
            if (carId < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(carId), "Car ID cannot be less or equal to zero.");
            }

            var car = _data.FirstOrDefault(c => c.Id == carId);
            if (car is not default(Car))
            {
                return Task.FromResult(car);
            }

            throw new InvalidOperationException($"There is no car with ID = {carId}.");
        }

        public Task<Car> GetCarByNumberAsync(string carNumber)
        {
            if (string.IsNullOrEmpty(carNumber)
                || carNumber.Length < 6)
            {
                throw new ArgumentOutOfRangeException(nameof(carNumber));
            }

            var car = _data.FirstOrDefault(c => c.Number == carNumber);
            if (car is not default(Car))
            {
                return Task.FromResult(car);
            }

            throw new InvalidOperationException($"There is no car with number = {carNumber}.");
        }
    }
}
