using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.API.Core.Entities
{
    public class Veiculo
    {

        // Propriedades Externas
        public Guid Id { get; private set; }
        public string Fabricante { get; private set; }
        public string Modelo { get; private set; }
        public ushort Ano { get; private set; }

        /// <summary>
        /// VIN (Vehicle Identification Number):
        /// Um número único de identificação do veículo, 
        /// atribuído por fabricantes e usado internacionalmente para identificar veículos. 
        /// Ele é uma string alfanumérica que normalmente contém 17 caracteres.
        /// </summary>
        public string VIN { get; private set; }
        public string Cor { get; private set; }
        public string Placa { get; private set; }

        // Propriedades Internas
        public ulong Quilometragem { get; private set; }
        public ushort PotenciaDoMotor { get; private set; }
        public string Transmissao { get; private set; }
        public string TipoDeCombustivel { get; private set; }
        public int CapacidadeDeAssentos { get; private set; }
        public string CaracteristicasInternas { get; private set; }
        public string CaracteristicasExternas { get; private set; }

        // Construtor
        public Veiculo(Guid id, string fabricante, string modelo, ushort ano, string vin, string cor, string placa,
                       ulong quilometragem, ushort potenciaDoMotor, string transmissao, string tipoDeCombustivel,
                       int capacidadeDeAssentos, string caracteristicasInternas, string caracteristicasExternas)
        {
            Id = id;
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
            VIN = vin;
            Cor = cor;
            Placa = placa;
            Quilometragem = quilometragem;
            PotenciaDoMotor = potenciaDoMotor;
            Transmissao = transmissao;
            TipoDeCombustivel = tipoDeCombustivel;
            CapacidadeDeAssentos = capacidadeDeAssentos;
            CaracteristicasInternas = caracteristicasInternas;
            CaracteristicasExternas = caracteristicasExternas;
        }

        // Métodos adicionais e comportamentos podem ser adicionados aqui

    }
}
