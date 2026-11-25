using WebContatos.Models;
using WebContatos.Data;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace WebContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel ListaPorId(int id)
        {
            return _bancoContext.TBContatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //gravar no banco de dados
            _bancoContext.TBContatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
            
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.TBContatos.ToList();
        }


        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListaPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("houve um erro na atualização do contato");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _bancoContext.TBContatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListaPorId(id);

            if (contatoDB == null) throw new System.Exception("houve um erro na dele~sao do contato");

            _bancoContext.TBContatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
