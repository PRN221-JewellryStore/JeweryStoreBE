using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Models.FileUpload
{
    [NotMapped]
    public class FileUploadModel
    {
        public IFormFile File { get; set; }
    }
}
