using C_Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace E_Database
{
    public class BookDatabase : IBookDatabase
    {
        private readonly IConfiguration _configuration;
        public string FilePath { get; set; }

        public BookDatabase(IConfiguration configuration)
        {
            _configuration = configuration;
            FilePath = GetFilePath();
        }

        public static string GetSolutionBasePath()
        {
            string projectName = "DocumentManager";
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            int startIndex = basePath.IndexOf(projectName, StringComparison.OrdinalIgnoreCase);
            return basePath.Substring(0, startIndex);
        }

        public string GetFilePath()
        {
            string? fileName = _configuration["FilePaths:Default"];
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            return Path.Combine(GetSolutionBasePath(), fileName);
        }
    }
}
