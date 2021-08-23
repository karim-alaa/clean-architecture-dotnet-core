using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Utilities
{
    public class GResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
    }
}
