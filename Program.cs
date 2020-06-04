using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva a data e horário de seu nascimento: ");
            DateTime nascimento=Convert.ToDateTime(Console.ReadLine());
            Console.Write("Escreva a data de quando será ou quando foi seu aniversário de 18 anos: ");
            DateTime niver18=Convert.ToDateTime(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Você nasceu dia {nascimento}");
            Console.WriteLine($"A data do seu aniversário de 18 anos será/foi dia {niver18}");
            

        }
    }
}
