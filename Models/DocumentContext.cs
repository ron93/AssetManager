using DocumentUpoadAPI.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DocumentUpoadAPI.Models
{
    public class DocumentContext :DbContext
    {
        public DocumentContext(DbContextOptions<DocumentContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Document> Documents { get; set; }
    }
}