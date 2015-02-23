using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class InsereAluno
    {
        static void Main(string[] args)
        {
            using (var db = new K19Context())
            {
                string nomeAluno, logradouro, cep;
                int numero;
                Aluno cadAluno;

                Console.WriteLine("Digite o nome do aluno a ser cadastrado: ");
                nomeAluno = Console.ReadLine();

                Console.WriteLine("Digite a rua de residência do aluno {0}: ", nomeAluno);
                logradouro = Console.ReadLine();

                Console.WriteLine("Digite o número da residência do aluno {0}: ", nomeAluno);
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o cep de residência do aluno {0}: ",nomeAluno);
                cep = Console.ReadLine();

                cadAluno = new Aluno() { Nome = nomeAluno, Endereco = new Endereco() { Logradouro = logradouro, CEP = cep, Numero = numero } };

                db.Alunos.Add(cadAluno);
                db.SaveChanges();
            }
        }
    }
}
