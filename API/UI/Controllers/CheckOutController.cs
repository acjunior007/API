using Domain.Interfaces;
using Domain.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    [Route("api/checkout")]
    [ApiController]
    public class CheckOutController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public CheckOutController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Buscar o customer, pesquisando pelo e-mail
        /// </summary>
        /// <param name="documento"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("{email}/buscarcliente")]
        public async Task<ActionResult<ListCustomers>> Buscarcliente(string email)
        {
            try
            {
                ListCustomers customer = await _clienteService.BuscarCliente(email);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}