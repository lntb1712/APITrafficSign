using APITrafficSign.Models;

namespace APITrafficSign.Services
{
    public interface ITrafficSignService
    {
        Task<TrafficSign?> getTrafficSignByIdAsync(string id);
    }
}
