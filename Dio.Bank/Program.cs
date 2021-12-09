using System;
namespace DIO.Bank
{
    class Program
    {
        static List<conta> ListContas = new List<conta>();
        static void Main(string[] args)
        {  
            string opecaoUsuario= ObeterOpcaoUsuario();

             while(opecaoUsuario.ToUpper() != "X")
             {
                 switch(opecaoUsuario)
                 {
                     case "1":
                     ListarContas();
                     break;
                     case "2":
                     InserirConta();
                     break;
                     case "3":
                     Transferir();
                     break;
                     case "4":
                     Sacar();
                     break;
                     case "5":
                     Depositar();
                     break;
                     case "C":
                     Console.Clear();
                     break;
                     default:
                     throw new ArgumentOutOfRangeException();
                 
                 }
                 
                 opecaoUsuario = ObeterOpcaoUsuario();
             } 
                Console.WriteLine("Obrigado por utilizar o nosso serviços.");
                 Console.ReadLine();
        }
        private static void Transferir()
        {
            Console.Write("digite o numero da conta origem: ");
            int ContaOrigem= int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta destino: ");
            int contaDestino= int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser tranferido: ");
            double valortransferido= double.Parse(Console.ReadLine());

            ListContas[ContaOrigem].Transferir(valortransferido,ListContas[contaDestino]);
        }
        private static void Depositar()
        {
             Console.Write("Digite o numeo da conta: ");
            int indicConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depostado: ");
            double Valordeposito2= double.Parse(Console.ReadLine());
            ListContas[indicConta].Depositar(Valordeposito2);
        }
        private static void Sacar()
        {
            Console.Write("Digite o numeo da conta: ");
            int indicConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double ValorSacar1= double.Parse(Console.ReadLine());
            ListContas[indicConta].Sacar(ValorSacar1);
        }

        private static void InserirConta()
        {
            Console.WriteLine("Insirir novaa conta");
            Console.Write("digite 1 para conta Fsica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome= Console.ReadLine();
            Console.Write("Digite o saldo inicial: ");
            double entradasaldo= double.Parse(Console.ReadLine());
            Console.Write("digite o valor do crédito: ");
            double entradaCredito=double.Parse(Console.ReadLine());

            conta novaConta= new conta(tipoConta: (TipoConta)entradaTipoConta,
                                       saldo: entradasaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);
             ListContas.Add(novaConta);                           
        }
        private static void ListarContas()
        {
            Console.WriteLine("listar Contas");
            if (ListContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
                
            }
            for (int i=0; i < ListContas.Count; i++)
            {
                conta conta= ListContas[i];
                Console.WriteLine("#"+i+"- "+conta);
                
            }
        }

        private static string ObeterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- LImpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuraio= Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuraio;
            
        }
    }
}
