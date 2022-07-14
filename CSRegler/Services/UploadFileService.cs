using CSRegler.Data;
using CSRegler.Models;
using Microsoft.EntityFrameworkCore;

namespace CSRegler.Services
{
    public class UploadFileService : IUploadFileService
    {
        public async Task AddNewFileAsync(UplodedFileModel model)
        {
            using(var context=new BilderDbContext())
            {
                await context.uplodedFileModels.AddAsync(model);
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdateFileAsync(UplodedFileModel model)
        {
            using var context = new BilderDbContext();
            context.uplodedFileModels.Update(model);

            //if (await context.SaveChangesAsync() > 0)
            //{
                //            NavigationManager.NavigateTo("/");
            //    NavigationManager.NavigateTo(@DPSeite);
            //}
            
        }
        public async Task<List<UplodedFileModel>> GetAllFilesAsync()
        {
            using (var context = new BilderDbContext())
            {
                return await context.uplodedFileModels.ToListAsync();
            }

        }
    }
}
