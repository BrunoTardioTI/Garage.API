using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Core.Entities
{
    public class Usuario
    {
      
        // Propriedades Básicas
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataDeNascimento { get; private set; }

        // Propriedades Adicionais
        public string Endereco { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public DateTime? UltimoLogin { get; private set; }

        /// <summary>
        /// Funções ou papéis do usuário (admin, usuário regular, etc.).
        /// </summary>
        public string Roles { get; private set; }
        public bool Ativo { get; private set; }


        public Usuario(string nome, string email, string senha, string telefone, DateTime dataDeNascimento,
                       string endereco, string roles)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = HashSenha(senha); 
            Telefone = telefone;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
            DataDeCadastro = DateTime.UtcNow; 
            Roles = roles;
            Ativo = true; 
        }

        // Método para hash da senha (simplificado, idealmente use uma biblioteca robusta)
        private string HashSenha(string senha)
        {
            // Implementar hashing seguro da senha aqui
            return senha; // Placeholder, substituir por hashing real
        }

        // Métodos adicionais e comportamentos podem ser adicionados aqui

        public void AtualizarUltimoLogin()
        {
            UltimoLogin = DateTime.UtcNow;
        }

        public void DesativarUsuario()
        {
            Ativo = false;
        }
    }
}
