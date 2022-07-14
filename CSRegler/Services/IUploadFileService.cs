using CSRegler.Models;

namespace CSRegler.Services
{
    public interface IUploadFileService
    {
        Task AddNewFileAsync(UplodedFileModel model);
        Task UpdateFileAsync(UplodedFileModel model);
        //Lets get data to fill in table
        Task<List<UplodedFileModel>> GetAllFilesAsync();

    }
}
