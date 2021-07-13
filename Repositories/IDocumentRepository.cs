using DocumentUpoadAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentUpoadAPI.Repositories
{
    public interface IDocumentRepository 
    {

        Task<IEnumerable<Document>> GetDocuments();

        Task<Document> GetDocument(int id);

        Task<Document> Create(Document document);

        Task Update(Document document);

        Task Delete(int id);
    }
}