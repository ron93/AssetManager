using DocumentUpoadAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentUpoadAPI.Repositories
{
    public interface IDocumentRepository 
    {
        //task to get all documents
        Task<IEnumerable<Document>> GetDocuments();

        //task to get a document
        Task<Document> GetDocument(int id);

        //task to create a document
        Task<Document> Create(Document document);

        //task to update a document
        Task Update(Document document);

        //task to delete a document
        Task Delete(int id);
    }
}