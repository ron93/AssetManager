using System.Collections.Generic;
using System.Threading.Tasks;
using DocumentUpoadAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DocumentUpoadAPI.Repositories

{
    public class DocumentRepository : IDocumentRepository
    {
        public readonly DocumentContext _context;
        public  DocumentRepository(DocumentContext context)
        {
            _context = context;
        }

        public async Task<DocumentOnDatabase> Create(DocumentOnDatabase document)
        {
          _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return document;
        }

        public async Task<DocumentOnFileSystem> Create(DocumentOnFileSystem document)
        {
              _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return document;
        }

        public async Task Delete(int id)
        {
             var documentToDelete = await _context.Documents.FindAsync(id);
            _context.Documents.Remove(documentToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DocumentOnDatabase>> GetallDb()
        {
            return await _context.Documents.ToListAsync();

        }

        public async Task<IEnumerable<DocumentOnFileSystem>> GetAllFile()
        {
            return await _context.Documents.ToListAsync();

        }

        public async Task<DocumentOnDatabase> GetOneDb(int id)
        {
            return await _context.Documents.ToListAsync();
        }

        public async Task<DocumentOnFileSystem> GetOneFile(int id)
        {
            return await _context.Documents.FindAsync(id);
        }

        public async Task Update(DocumentOnDatabase document)
        {
            _context.Entry(document).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Update(DocumentOnFileSystem document)
        {
            _context.Entry(document).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}