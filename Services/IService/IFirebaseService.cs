using BusinessObjecs.Models.FileUpload;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IService
{
    public interface IFirebaseService
    {
        public Task<string> Push(IFormFile file, FileStream data);
    }
}
