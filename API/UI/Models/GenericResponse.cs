using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class GenericResponse
    {
        public GenericResponse(bool sucesso, dynamic data)
        {
            Sucesso = sucesso;
            Data = data;
        }

        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }

        public dynamic Data { get; set; }
    }
}