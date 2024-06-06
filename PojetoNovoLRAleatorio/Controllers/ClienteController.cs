using Microsoft.AspNetCore.Mvc;
using ProjetoNovoLRAleatorio.Models;
using ProjetoNovoLRAleatorio.Repositorio;

namespace ProjetoNovoLRAleatorio.Controllers
{
    public class ClienteController : Controller
    {
        // ILogger permite retornar erros e avisos dos nossos sistemas de forma simples e fácil
        private readonly ILogger<ClienteController> _logger;
        private IClienteRepositorio? _clienteRepositorio;

        // criando um metodo para receber a interface do looger e do repositorio cliente

        public ClienteController(ILogger<ClienteController> logger, IClienteRepositorio clienteRepositorio)
        {
            _logger = logger;
            _clienteRepositorio = clienteRepositorio;

        }

        public IActionResult Cliente()
        {
              
            return View(_clienteRepositorio.TodosClientes());
        }

        public IActionResult CadCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadCliente(Cliente cliente)
        {
            //metodo cadastra 
           _clienteRepositorio.Cadastrar(cliente);

            //redireciona para index
            return RedirectToAction(nameof(Cliente));
        }

    }
}
