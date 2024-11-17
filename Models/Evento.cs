﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada para a duração do evento
        public int DuracaoDias => (DataTermino - DataInicio).Days + 1;

        // Propriedade calculada para o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante * DuracaoDias;
    }
}
