namespace TargeInverterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string frase = "Desafiador para um aspirante a estagiario mas consegui";

            // ToCharArray passa para o array os caracteres da string
            char[] letras = frase.ToCharArray();

            // inverter os caracteres com for
            int tamanho = letras.Length;
            for (int i = 0; i < tamanho / 2; i++)
            {
                char guarda = letras[i];
                letras[i] = letras[tamanho - 1 - i];
                letras[tamanho - 1 - i] = guarda;
            }

            // converte para string denovo
            string invertida = new string(letras);


            Console.WriteLine(invertida);
        }
    }
}