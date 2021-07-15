using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DocumentUpoadAPI.Models
{
    public class Document
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength =5)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }


    }
}