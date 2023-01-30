namespace BancoImpacta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();

            c1.Titular = "Vinicius";
            c1.NConta = 1965;
            c1.Saldo = 1000;
            c1.ContaVIP = true;

            c1.ExibirSaldo();   // exibir 1000   
            c1.Sacar(700);      // sacar 700
            c1.ExibirSaldo();   // exibir 300     
            c1.Depositar(350);  // depositar 350
            c1.ExibirSaldo();   // exibir 650



            // Transferência

            Conta c2 = new Conta();

            c2.Titular = "Fernando";
            c2.NConta = 2046;
            c2.Saldo = 2000;

            Console.WriteLine(new String('-', 70) + "\n");
            Console.WriteLine("Antes da tentativa de transferência:");
            c1.ExibirSaldo();
            c2.ExibirSaldo();

            Console.WriteLine(new String('-', 70) + "\n");
            c1.Transferir(c2, 1500);
            Console.WriteLine("Depois da tentativa de transferência:");
            c1.ExibirSaldo();
            c2.ExibirSaldo();
            Console.WriteLine(new String('-', 70) + "\n");


            Conta c3 = new Conta(2851, "Jhony");
            c3.ExibirSaldo();

        }
    }
}