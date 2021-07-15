using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DocumentUpoadAPI.Models
{
    public class DocumentOnDatabase : Document
    {
        public byte [] Data { get; set;}

    }

}
