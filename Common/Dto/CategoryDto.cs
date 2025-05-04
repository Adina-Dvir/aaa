using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class CategoryDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public byte[]? ArrImage { get; set; }
        public IFormFile? fileImage { get; set; }

    }
}
