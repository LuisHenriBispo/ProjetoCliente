﻿using ProjetoNovoLRAleatorio.Models;

namespace ProjetoNovoLRAleatorio.Repositorio
{
    public interface IClienteRepositorio
    {
        //crud
        IEnumerable<Cliente> TodosClientes();

        void Cadastrar(Cliente cliente);
    }

    
}
