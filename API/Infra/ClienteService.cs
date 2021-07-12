using Domain.DTO;
using Domain.Interfaces;
using Domain.Response;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infra
{
    public class ClienteService : IClienteService
    {
        public ClienteService(ICustomService customService)
        {
            _customService = customService;
        }

        private readonly ICustomService _customService;

        public async Task<ListCustomers> BuscarCliente(string documento)
        {
            var customer = await _customService.GetAsync<ListCustomers>($"customers?query=email={documento}");

            return customer;
        }

        public Task<CustomerResponse> IncluirCliente(Customer customer)
        {
            throw new NotImplementedException();
        }

        private string GetCustomer()
        {
            return @"
                    {
                      'id': 1099424,
                      'name': 'Antonio c Santos jr',
                      'email': 'guest@gmail.com',
                      'registry_code': '45138716018',
                      'code': null,
                      'notes': '',
                      'status': 'active',
                      'created_at': '2021-07-08T16:49:06-03:00',
                      'updated_at': '2021-07-08T16:50:50-03:00',
                      'address': {
                        'street': 'R. do Paraíso',
                        'number': '148',
                        'additional_details': null,
                        'zipcode': '04103000',
                        'neighborhood': 'Liberdade',
                        'city': 'São Paulo',
                        'state': 'SP',
                        'country': 'BR'
                      },
                      'phones': [
                        {
                          'id': 272977,
                          'phone_type': 'mobile',
                          'number': '5511963180035',
                          'extension': null
                        }
                      ]
                    }

                ";
        }
    }
}