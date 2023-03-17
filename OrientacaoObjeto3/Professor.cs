﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto3
{
    internal class Professor:Pessoa
    {
        public double Salario{ get; set; }

        public Professor(string nome, string telefone, string endereco,
            double salario):base(nome, telefone, endereco)
        {
            //base = esta herdando os métodos da classe pai e passando para os
            //parametros do construtor professor

            Salario = salario;
        }

        public Professor(Pessoa p, double salario):base(p.Nome, p.Telefone,
            p.Endereco)
        {
            Salario = salario;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Salario;
        }
    }
}
