using System.Diagnostics;

namespace Virus
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bool PalmeirasNaoTemMundial = true;
            Console.WriteLine("Virus infinito...");
            Console.Write("Entre com o nome do programa: ");
            string programa = Console.ReadLine();

            if (programa == "") return;
            if (programa=="list")
            {
                Console.WriteLine("Listando todos os processos ativos ");
                Process[] ListarProcessos = Process.GetProcesses();
                foreach (var item in ListarProcessos)
                {
                    Console.WriteLine(item.ProcessName);
                }
                return;
            }        
           
            do
            {
                Process[] TodosProcessos = Process.GetProcessesByName(programa);
                if (TodosProcessos.Length > 0)
                {
                    Console.WriteLine($"Instancias ativas de {TodosProcessos[0].ProcessName}: {TodosProcessos.Length}");

                }

                if (TodosProcessos.Length < 1)
                {
                    try
                    {
                        Process.Start($"{programa}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Processo {programa} não encontrado");
                        break;
                        
                    }
                    
                }

            } while (PalmeirasNaoTemMundial);

         
            
        }
    }
}