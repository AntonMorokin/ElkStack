using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Data
{
    public interface ICarRepository
    {
        Task<Car> GetCarByNumberAsync(string carNumber);

        Task<Car> GetCarByIdAsync(int carId);
    }
}
