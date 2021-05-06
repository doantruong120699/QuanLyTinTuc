using Microsoft.EntityFrameworkCore;
using QuanLyTinTuc.Core.Models;
using System.Threading.Tasks;
namespace QuanLyTinTuc.Core.Helpers
{
    public class SeedHelper
    {
        public static async Task SeedCategories(DataContext context)
        {
            if (await context.Categories.AnyAsync())
            {
                // if it have already exist, it'll not be added.
                return;
            }
            await context.Categories.AddAsync(new Category { Name = "Phone" });
            await context.Categories.AddAsync(new Category { Name = "Tivi" });
            await context.SaveChangesAsync();
        }

        public static  async Task SeedTInTucs(DataContext context){
            if(await context.TinTucs.AnyAsync()){
                return;
            }
            await context.TinTucs.AddAsync(new TinTuc{
                Name = "IPhone 12",
                CategoryId = 1,
                Description = "This is IPhone 12",
                ImageUrl = "this is url image"
            });
            await context.TinTucs.AddAsync(new TinTuc{
                Name = "IPhone 13",
                CategoryId = 2,
                Description = "This is IPhone 13",
                ImageUrl = "this is url image"
            });
            await context.SaveChangesAsync();
        }

    }
}