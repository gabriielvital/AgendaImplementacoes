using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaImplementacoes.Domain.Tarefas
{
    public sealed class Agendamento
    {
        public DateOnly Data { get; }
        public TimeOnly Hora { get; }
        public TipoAgendamento Tipo { get; }
        public Guid ClienteId { get; }

        public Agendamento(DateOnly data, TimeOnly hora, TipoAgendamento tipo, Guid clienteId)
        {
            if(clienteId == Guid.Empty)
            {
                throw new ArgumentException("O agendamento precisa de um cliente", nameof(clienteId));
            }
            Data = data;
            Hora = hora;
            Tipo = tipo;
            ClienteId = clienteId;

        }

        public override bool Equals(object? obj) =>
            obj is Agendamento outro
            && Data == outro.Data
            && Hora == outro.Hora
            && Tipo == outro.Tipo
            && ClienteId == outro.ClienteId;



    }
}
