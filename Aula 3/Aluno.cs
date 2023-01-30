using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Aluno
    {
        // No padrão da Microsoft atributos da classe são maiusculos, parametros (mesmo que de mesmo nome) em minusculo.
        public string Nome;
        public string Turma;
        public int Idade;
        public int NMat;
        public decimal Mensalidade;

        public void ExibirAluno()
        {
            Console.WriteLine($"Aluno: {Nome} - Turma: {Turma} - Idade: {Idade} - Mensalidade: {Mensalidade:0.00}");
        }

        // Metodo que vai efetuar a troca de turma do aluno requerente
        public void TrocarTurma(string novaTurma)
        {
            Turma = novaTurma;
        }

        public void Desconto(decimal desconto)
        {
            Mensalidade = Mensalidade - (desconto / 100) * Mensalidade;
        }


    }
}