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
            DateTime atual = DateTime.Now;/*Parse(DateTime.Now.GetDateTimeFormats()*/
            DateTime nascimento = pessoa.dataNascimento;
            int idade;

            int nascimentoYear = nascimento.Year;
            int nascimentoMonth = nascimento.Month;
            int nascimentoDay = nascimento.Day;

            int atualYear = atual.Year;
            int atualMonth = atual.Month;
            int atualDay = atual.Day;

            if (nascimentoMonth >= atualMonth && nascimentoDay > atualDay)
            { 
                idade = atualYear - nascimentoYear - 1; 
            }
            else
            {
                idade = atualYear - nascimentoYear;
            }
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
