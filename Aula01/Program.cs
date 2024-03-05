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
        //string resultado = calculaIMC.Calcular(peso, altura); *mudar*
        Console.WriteLine(calculaIMC.Calcular(peso, altura));
        entrada = false;
        Console.WriteLine("Informe um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe um número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        var calculadora = new Calculadora();
        Console.WriteLine($"A soma dos números {num1} + {num2} = {calculadora.Soma(num1, num2)} ");
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);

//Joaquim decidiu refatorar seu código eliminando a linha comentada abaixo, mas mantendo o mesmo funcionamento.
//Informe que alteração ele realizou


//Crie uma classe chamada Calculadora, que possua um método que some dois numeros inteiros e retorne o resultado dessa soma. o nome do método deve ser Soma. Ao final deverão ser exibidos os números informados e o valor da soma.


 