internal class Program
{
    private static void Main(string[] args)
    {
        int count;
        float[] numbers = new float[15];
        float maior = 0, menor = 0;

        for (count = 0; count < 15; count++)
        {
            Console.WriteLine($"Digite o {count+1}° número:");
            numbers[count] = float.Parse(Console.ReadLine());

            if(count == 0)
            {
                maior = numbers[0];
                menor = numbers[0];
            }
            else
            {
                if (numbers[count] > maior)
                    maior = numbers[count];
                else
                {
                    if(numbers[count] < menor)
                        menor = numbers[count];
                }
            }
        }

        if(maior == menor)
            Console.WriteLine("Os números são iguais");
        else
        {
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }

    }
}