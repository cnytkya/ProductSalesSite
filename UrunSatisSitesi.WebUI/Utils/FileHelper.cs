﻿namespace UrunSatisSitesi.WebUI.Utils
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile formFile, string filePath = "/wwwroot/Img/")
        {
            string fileName = "";

            fileName = formFile.FileName;

            string directory = Directory.GetCurrentDirectory() + filePath + fileName;

            using var stream = new FileStream(directory, FileMode.Create);

            await formFile.CopyToAsync(stream);

            return fileName;
        }
    }
}
