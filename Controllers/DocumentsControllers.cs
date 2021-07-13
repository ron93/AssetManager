using DocumentUpoadAPI.Models;
using DocumentUpoadAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DocumentUpoadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DocumentController : ControllerBase
    {
        private readonly IDocumentRepository _documentRepository;
        public DocumentController(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Document>> GetDocuments() 
        {
            return await _documentRepository.GetDocuments();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Document>> GetDocument(int id)
        {
            return await _documentRepository.GetDocument(id);
        }


        [HttpPost]
        public async Task<ActionResult<Document>>PostDocument([FromBody] Document document)
        {
            var newDocument = await _documentRepository.Create(document);
            return CreatedAtAction(nameof(GetDocument) ,new{IDocumentRepository=newDocument.Id}, newDocument);

        }

        [HttpPut]
        public async Task<ActionResult> PutDocument(int id, [FromBody] Document document)
        {
            if(id != document.Id) 
            {
                return BadRequest();

            }
            await _documentRepository.Update(document);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteDocument(int id)
        {
            var documentToDelete = await _documentRepository.GetDocument(id);
            if(documentToDelete == null)
            {
                return NotFound();
            }

            await _documentRepository.Delete(documentToDelete.Id);
            return NoContent();
        }


    }
}