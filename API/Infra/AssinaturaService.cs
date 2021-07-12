using Domain.Interfaces;
using Domain.Request;
using Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class AssinaturaService : IAssinaturaService
    {
        private readonly ICustomService _customService;

        public AssinaturaService(ICustomService customService)
        {
            _customService = customService;
        }

        public async Task<AssinaturaResponse> IncluirAssinatura(AssinaturaRequest assinatura)
        {
            AssinaturaResponse response = new AssinaturaResponse();
            // verificar se ja existe uma assinatura ativa para o customerId
            // var assinatura = await ConsultarAssinaturaPorCustomerId(assinaturaRequest.CustomerId);

            response = await _customService.PostAsync<AssinaturaResponse>("subscriptions", assinatura);

            return response;
        }
    }
}