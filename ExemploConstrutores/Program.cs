using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
 {
    class Program
    {
       static void Main(string[] args)
       {

         Data data = new Data();
         data.SetMes(2);
         data.Mes = 12;
         System.Console.WriteLine(data.Mes);

         data.ApesentarMes();
         //Log log = Log.GetInstance();
         // log.PropriedadeLog = "Teste instancia";

         //Log log2 = Log.GetInstance();
         // System.Console.WriteLine(log2.PropriedadeLog);

         //Pessoa p1 = new Pessoa();
         //p1.Apresentar();
         {
       
   };
{
    
}
       }
       
    }
    
}




