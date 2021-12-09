using System;
namespace DIO.Bank
{
    public class conta
    {    private TipoConta  tipoConta{get; set;}

         private double Saldo {get; set;}
         private double credito{get; set;}
         
         private string nome{get; set;}
         

         public conta(TipoConta tipoConta, double saldo,double credito, string nome)
         {
             this.tipoConta = tipoConta;
             this.Saldo= saldo;
             this.credito= credito;
             this.nome = nome;

         }
         public bool Sacar(double valorSaque)
         {
             //Validação de Saldo Sudiciente
             if(this.Saldo - valorSaque <(this.credito *-1) )
             {
                 Console.WriteLine("Saldo insuficinete");
                 return false;
             }
             this.Saldo -= valorSaque;
             Console.WriteLine("Saldo atual da conta de "+this.nome+" é "+this.Saldo);
             return true;
         }
         public void Depositar(double valorDeposito)
         {
             this.Saldo+= valorDeposito;
             Console.WriteLine("Saldo atual da conta de "+this.nome+" é "+this.Saldo);
         }

         public void Transferir(double ValorTransferencia, conta contaDestino)
         {
             if(this.Sacar(ValorTransferencia))
             {
                 contaDestino.Depositar(ValorTransferencia);
             }
         }  
          public override string ToString()
          {
              string retorno ="";
              retorno+= "TipoConta "+ this.tipoConta+ " | ";
              retorno+= "Nome "+ this.nome +  " | ";
              retorno+= "Saldo " + this.Saldo + " | ";
              retorno+= "Credito " + this.credito;
              return retorno;
          }
         
    }
}