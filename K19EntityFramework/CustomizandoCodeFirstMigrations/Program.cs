using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomizandoCodeFirstMigrations
{
    class Program
    {
        static void Main(string[] args)
        {

            //Página 76

            RepositorioPessoa repositorio;
            Console.Write("Digite 1 para listar as Pessoas cadastradas ou qualquer outra tecla para cadastrar nova pessoa:");
            string teclaDigitada= Console.ReadLine();

            if (teclaDigitada.Equals("1"))
            {
                 repositorio= new RepositorioPessoa(new kContext());

                foreach (var pessoa in repositorio.Listar())
                {
                    Console.WriteLine("{0}, {1},{2},{3}.", pessoa.Nome, pessoa.Email, pessoa.TelefoneFixo, pessoa.Celular);
                }
            }
            else
            {
                repositorio = new RepositorioPessoa(new kContext());
                string nome, cel, email, fone;
                
                Console.WriteLine("Digite o nome da pessoa:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o celular de {0}:",nome);
                cel = Console.ReadLine();

                Console.WriteLine("Digite o email de {0}:", nome);
                email = Console.ReadLine();

                Console.WriteLine("Digite o telefone fixo de {0}:", nome);
                fone = Console.ReadLine();

                Pessoa p = new Pessoa() { Nome = nome, Celular = cel, Email = email, TelefoneFixo = fone };
                repositorio.Adicionar(p);
            }
            

            
            Console.ReadKey();
        }
    }
}
