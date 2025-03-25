using APITrafficSign.Models;

namespace APITrafficSign.Services
{
    public class TrafficSignService:ITrafficSignService
    {
        private readonly TrafficSignRecorgnitionContext _context;

        public TrafficSignService(TrafficSignRecorgnitionContext context)
        {
            _context = context;
        }

        public async Task<TrafficSign?> getTrafficSignByIdAsync(string id)
        {
            return await _context.TrafficSigns.FindAsync(id);
        }
    }
}
