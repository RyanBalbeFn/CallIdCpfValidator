using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CallIdCpfValidator
{
    internal class CallRepository
    {
        // banco de dados fictício
        private readonly Dictionary<string, string> calls = new()
    {
        { "CALL001", "12345678900" },
        { "CALL002", "98765432100" },
        { "CALL003", "45678912300" }
    };

        // consulta
        public CallRecord? GetByCallId(string callID)
        {
            if (calls.ContainsKey(callID))
            {
                string cpf = calls[callID];

                // cria o valor com cpf e callID
                return new CallRecord
                {
                    CallId = callID,
                    Cpf = cpf
                };
            }
            return null;
        }
    }
}
