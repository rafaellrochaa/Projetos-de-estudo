using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework
{
    public class ListaAluno
    {
        static void Main(string[] args)
        {
            using (var db = new K19Context())
            {
                var consulta = from aluno in db.Alunos select aluno;

                Console.WriteLine("<<Dados Alunos>>\n");

                foreach(var aluno in consulta)
                {
                    Console.WriteLine("Nome: {0} \nLogradouro: {1}\nNúmero: {2}\nCEP: {3} \n",
                        aluno.Nome, aluno.Endereco.Logradouro, aluno.Endereco.Numero, aluno.Endereco.CEP);
                }
                Console.WriteLine("\nPressione enter para finalizar o programa.");
                Console.ReadKey();
            }
        }
    }
}
