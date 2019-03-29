using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaB1.Models
{
    public class Funcionario
    {
        private int _id;
        private string _nome;
        private string _usuario;
        private string _senha;

        public Funcionario()
        {
            Id = 0;
            Nome = "";
            Usuario = "";
            Senha = "";
        }
        public Funcionario(int id, string nome, string usuario, string senha)
        {
            Id = id;
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }

        public Boolean Autenticar(string usuario, string senha)
        {
            if ((usuario == "123") && (senha == "123"))
                return true;
            else return false;
        }
    }
}
