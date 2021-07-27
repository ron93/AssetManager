using DocumentUpoadAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentUpoadAPI.Repositories
{
    public interface IDocumentRepository 
    {
        //get all books
        Task<IEnumerable<DocumentOnDatabase>> GetallDb();
        Task<IEnumerable<DocumentOnFileSystem>> GetAllFile();

        //get one book
        Task<DocumentOnDatabase> GetOneDb(int id);
        Task<DocumentOnFileSystem> GetOneFile(int id);

        //create a book
        Task<DocumentOnDatabase> Create(DocumentOnDatabase document);
        Task<DocumentOnFileSystem> Create(DocumentOnFileSystem document);

        //update a book
        Task Update(DocumentOnDatabase document);
        Task Update(DocumentOnFileSystem document);

        //delete a book
        Task Delete(int id);
        
        
    }
       
    }
}