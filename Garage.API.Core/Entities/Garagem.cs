using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Core.Entities
{
    public class Garagem
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }
        public List<Veiculo> Veiculos { get; private set; } = new List<Veiculo>();

        // Construtor
        public Garagem(Guid usuarioId)
        {
            UsuarioId = usuarioId;
            Id = Guid.NewGuid();
        }

        // Métodos para manipular a lista de veículos
        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(Veiculo veiculo)
        {
            Veiculos.Remove(veiculo);
        }
    }
}
