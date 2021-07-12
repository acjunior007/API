using Domain.DTO;
using Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClienteService
    {
        Task<ListCustomers> BuscarCliente(string documento);

        Task<CustomerResponse> IncluirCliente(Customer customer);
    }
}