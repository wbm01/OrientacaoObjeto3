using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto3
{
    internal class Estudante:Pessoa
    {
        public int Matricula { get; set; }
        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Peso1 { get; set; }

        public double Peso2 { get; set; }

        public Estudante(string nome, string telefone, string endereco,
            int matricula):base(nome, telefone, endereco)
        {
            Matricula = matricula;
           
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Matricula;
        }

        public double CalcularMedia(double nota1, double nota2)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return ((nota1 + nota2)/2);
        }

        public double CalcularMediaPeso(double nota1, double nota2,double peso1, double peso2)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Peso1 = peso1;
            Peso2 = peso2;

            return (nota1*peso1 + nota2*peso2)/(peso1+peso2);
        }
    }
}
