using System;
using System.Text.RegularExpressions;
namespace ClientControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_Nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_Endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
            
            if(var_tipo == "f")
            {
            // --- Pessoa Física ----
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.Nome = var_Nome;
            pf.Endereco = var_Endereco;
            Console.WriteLine("Informar CPF:");
            pf.CPF = Console.ReadLine();
            Console.WriteLine("Informar RG:");
            pf.RG = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + pf.Nome);
            Console.WriteLine("Endereço ......: " + pf.Endereco);
            Console.WriteLine("CPF ...........: " + pf.CPF);
            Console.WriteLine("RG ............: " + pf.RG);
            Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pf.Valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar  : " + pf.Total.ToString("C"));
            }
            if(var_tipo == "j")
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_Nome;
                pj.Endereco = var_Endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.IE = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CNPJ ..........: " + pj.CNPJ);
                Console.WriteLine("IE ............: " + pj.IE);
                Console.WriteLine("Valor de Compra: " + pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.Valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar  : " + pj.Total.ToString("C"));
            }
        }
    }
}