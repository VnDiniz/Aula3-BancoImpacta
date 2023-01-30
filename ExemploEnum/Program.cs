namespace ExemploEnum
{
    // o byte indica o tipo dos dados da enumeração
    enum EstadosCivis : byte
    {
        Casado,
        Solteiro,
        Viuvo,
        Separado,
        Outro
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            for (byte i=0; i <= 4; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(EstadosCivis),i));
            }
        }
    }
}