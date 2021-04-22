using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.DTOs
{
    public class ResultDTO
    {
        public List<string> Errors { get; set; }
        public bool Sucess { get; set; }
        public object Data { get; set; }
    }
}
