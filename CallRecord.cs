using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallIdCpfValidator
{
    internal class CallRecord
    {
        public required string CallId { get; set; }
        public required string Cpf {  get; set; }
    }
}
