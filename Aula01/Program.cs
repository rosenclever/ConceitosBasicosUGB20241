
//altere o programa para calcular o imc de uma pessoa
// imc = peso / altura * altura

using Aula01;
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
        CalculaIMC calculaIMC = new CalculaIMC();
        // Joaquim decidiu refatorar seu código eliminando a linha comentada abaixo, mas mantendo o mesmo funcionamento.
        // Informe que alteração ele realizou
        // string resultado = calculaIMC.Calcular(peso, altura);
        Console.WriteLine(calculaIMC.Calcular(peso, altura));
        //Crie uma classe chamada Calculadora, que possua um método que some dois número inteiros e retorne o resultado dessa soma. O nome do método deve ser Soma. Ao final deverão ser exibidos os números informados e o valor da soma
        Console.WriteLine("Informe um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe um número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //var calculadora = new Calculadora();
        Console.WriteLine($"A soma dos números {num1} + {num2} = {Calculadora.Soma(num1, num2)}");
        // sucesso
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);



