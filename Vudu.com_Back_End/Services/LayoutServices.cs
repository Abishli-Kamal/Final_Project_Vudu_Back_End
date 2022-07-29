using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context=context;
        }
        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> setting = await _context.Settings.ToListAsync();

            return setting;
        }
    }
}
