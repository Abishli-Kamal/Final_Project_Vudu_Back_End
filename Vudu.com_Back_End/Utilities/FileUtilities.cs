using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Vudu.com_Back_End.Utilities
{
    public static class FileUtilities
    {
        public static async Task<string> FileCreate(this IFormFile file,string root,string folder)
        {
            string filename=Guid.NewGuid()+file.FileName;
            string path = Path.Combine(root, folder);
            string fullpath=Path.Combine(path, filename);

            using (FileStream stream = new FileStream(fullpath,FileMode.Create))
            {
                await file.CopyToAsync(stream);

            }
            return filename;
        }
        public static void FileDelete(string root, string path, string imageName)
        {
            string fullPath = Path.Combine(root, path, imageName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
