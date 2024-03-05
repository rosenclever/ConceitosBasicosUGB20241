
//altere o programa para calcular o imc de uma pessoa
// imc = peso / altura * altura
using System.Globalization;

bool entrada = true;
do
{
    try
    {
        Console.WriteLine("Informe o peso atual: ");
        int peso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura atual: ");
        float altura = float.Parse(Console.ReadLine());
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);



