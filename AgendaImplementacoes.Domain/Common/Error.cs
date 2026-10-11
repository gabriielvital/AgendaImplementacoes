using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaImplementacoes.Domain.Common
{
    public sealed record Error(String Codigo, string Mensagem){
        public static readonly Error Nenhum = new(string.Empty, string.Empty);

        public static Error Validacao(string codigo, string mensagem) => new(codigo, mensagem);

        public static Error RegraDeNegocio(string codigo, string mensagem) => new(codigo, mensagem);
    }
}
