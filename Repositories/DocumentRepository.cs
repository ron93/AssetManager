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
        //create
        public async Task<Document> Create(Document document)
        {
            _context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return document;

        }
        //delete
        public async Task Delete(int id)
        {
            var documentToDelete = await _context.Documents.FindAsync(id);
            _context.Documents.Remove(documentToDelete);
            await _context.SaveChangesAsync();
        }

        //get one document
        public async Task<Document> GetDocument(int id)
        {
            return await _context.Documents.FindAsync(id);
        }

        //get all documents
        public async Task<IEnumerable<Document>> GetDocuments()
        {
            return await _context.Documents.ToListAsync();
        }

        //update document
        public async Task Update(Document document)
        {
            _context.Entry(document).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}