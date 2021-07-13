using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentUpoadAPI.Models
{
    public class Document
    {
        public int Id;
        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Name;

        [Required]
        [StringLength(100, MinimumLength =5)]
        public string Description;

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }
        public string Path;

    }
}