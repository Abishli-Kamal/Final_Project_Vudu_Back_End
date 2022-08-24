using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

      public async Task<List<MainOption>> GetMainOption()
        {
            List<MainOption> main = await _context.MainOptions.ToListAsync();

            return main;
        }
        public async Task<List<SubOptionTitle>> GetSubTitleOption()
        {
            List<SubOptionTitle> subTitle = await _context.SubOptionTitles.ToListAsync();

            return subTitle;
        }
        public async Task<List<SubOptionSubTitle>> GetSubOptionSubTitle()
        {
            List<SubOptionSubTitle> sub = await _context.SubOptionSubTitles.ToListAsync();

            return sub;
        }
        public async Task<List<SubOptionImage>> GetSubOptionImage()
        {
            List<SubOptionImage> subimage = await _context.SubOptionImages.ToListAsync();

            return subimage;
        }
        public async Task<List<BasketItem>> GetBasket(string username)
        {
            List<BasketItem> item = await _context.BasketItems.Include(s=>s.AppUser).Where(s=>s.AppUser.UserName==username).ToListAsync();

            return item;
        }


    }
}
