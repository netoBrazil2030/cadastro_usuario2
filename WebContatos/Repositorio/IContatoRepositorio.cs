using System.Collections.Generic;
using WebContatos.Models;

namespace WebContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        //metodo para buscar um contato pelo id
        ContatoModel ListaPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
