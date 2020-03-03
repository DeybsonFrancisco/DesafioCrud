using DesafioCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCrud.Utils
{
    public static class ValidateIdade
    {
        public static bool idadeConfirm(Pessoa pessoa)
        {
            int idade = pessoa.idade;
            Console.WriteLine(idade);
            if (idade < 18  || idade > 60)
            {
                return false;
            }   
            else
            {
                return true;
            }
                
        }
    }
}
