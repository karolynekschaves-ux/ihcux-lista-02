using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       Console.Title = "TerminalSuporte.ConsoleApp ";
       
       
         while (true)
        {
            Console.Clear();
            MostrarMenu();
            Console.Write("Digite um comando ");
            string comando = Console.ReadLine().ToUpper();
           
             switch (comando)
            {
                case "PING":
                    
                    Console.WriteLine("===DIAGNOSTICO DE REDE===");
                    Console.WriteLine("FORMATO ESPERADO : 192.168.0.1.(Somente número e pontos)");
                    Console.Write("Digite o IP de destino :");
                    string ipDestino = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write("[IHC] Enviando pacotes para " + ipDestino +"\n" );
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Resposta recebida com sucesso! Latência: 15ms\n");
                    Console.ResetColor(); 
                   
                    break;
        case "RESET":
       
            string resposta;
            bool sair = false;
            do {
           
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!!!AVISO DE SEGURANÇA !!!\n");
                Console.ResetColor();
               
                Console.WriteLine("Você solicitou o REBOOT do servidor central.");
                Console.WriteLine("Isso desconectará todos dos usuarios ativos.");
                Console.WriteLine("Tem certeza que deseja continuar? (S/N) : ");
                resposta = Console.ReadLine().ToLower();

            if (resposta == "n" || resposta == "não" || resposta == "nao" || resposta == "no")
            {
                Console.WriteLine("Operação cancelada pelo usuário.");
                sair = true;
            }
            else if (resposta == "s" || resposta == "sim" || resposta == "y")
            {
                Console.WriteLine("Reiniciando Sistema....");
                Thread.Sleep(1500);
                Console.WriteLine("Sistema Online.");
                sair = true; 
            }
            else
            {
                Console.WriteLine("Resposta inválida, tente novamente.");
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                
            }

        } while (!sair);
        break;

        case "HELP":
            Console.WriteLine("===AJUDA - COMANDOS DISPONIVEIS===");
            Console.WriteLine("PING - Testar Conexão com um IP");
            Console.WriteLine("RESET - Reiniciar o servidor (critico)");
            Console.WriteLine("HELP - Exibir esta mensagem de ajuda");
            Console.WriteLine("SAIR - Fechar o terminal");
            break;
        case "SAIR":
            Console.WriteLine("Fechando terminal...");
             return;
        default:
            Console.WriteLine("Comando desconhecido. Digite 'HELP' para ver os comandos disponíveis.");
            break;
    }
      Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
    }
}
             static void MostrarMenu()        
        {
        Console.WriteLine("STATUS SISTEMA OPERACIONAL");
        Console.WriteLine("==========================");
        Console.WriteLine("> [PING] - Testar Conexão" );
        Console.WriteLine("> [RESET] - Reiniciar servidor (critico)" );
        Console.WriteLine("> [HELP] - Ajuda" );
        Console.WriteLine("> [SAIR] - Fechar Terminal" );
 }
}
