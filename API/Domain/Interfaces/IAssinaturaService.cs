using Domain.Request;
using Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAssinaturaService
    {
        Task<AssinaturaResponse> IncluirAssinatura(AssinaturaRequest assinatura);
    }
}