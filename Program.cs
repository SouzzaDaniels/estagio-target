/// resposta 1-) 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91
///
Console.WriteLine("exercicio 1 ---------------------------");
int indice = 13, soma = 0, k = 0;

while(k < indice)
{
    k = k + 1; soma = soma + k;
    Console.WriteLine($"{soma}");
}
Console.WriteLine(""); 

///// resposta 2
///
Console.WriteLine("exercicio 2 ---------------------------");
  static bool Fibonacci(int n)
    {
        int a = 0, b = 1, c = 0;
        if (n == 0 || n == 1) return true;

        while (c < n)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c == n;
    }

        Console.Write("Informe um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (Fibonacci(numero))
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");

Console.WriteLine("");

/// resposta 3
/// 
Console.WriteLine("exercicio 3 ---------------------------");
double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;
double total = sp + rj + mg + es + outros;

    Console.WriteLine($"Percentual SP: {sp / total * 100}%");
    Console.WriteLine($"Percentual RJ: {rj / total * 100}%");
    Console.WriteLine($"Percentual MG: {mg / total * 100}%");
    Console.WriteLine($"Percentual ES: {es / total * 100}%");
    Console.WriteLine($"Percentual Outros: {outros / total * 100}%");

Console.WriteLine("");

/// reposta 4
/// 
Console.WriteLine("exercicio 4 ---------------------------");
static string Inverter(string str)
    {
        char[] chars = new char[str.Length];
        int index = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            chars[index] = str[i];
            index++;
        }

        return new string(chars);
    }

        Console.Write("Informe uma string: ");
        string entrada = Console.ReadLine();
        string invertida = Inverter(entrada);
        Console.WriteLine($"String invertida: {invertida}");        