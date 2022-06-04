// See https://aka.ms/new-console-template for more information

// 9. Escreva uma função que calcule e retorne o volume de uma circunferência,
// recebendo como parâmetro o raio.
// Volume = 4/3.PI.r^3

double Volume(double raio)
{
    double vol = (4 / 3) * Math.PI * Math.Pow(raio, 3);
    return vol;
}

// Main
// Pedir o raio ao utilizador

Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

Console.Write("Raio: ");
double raio = double.Parse(Console.ReadLine());

double resultado = Volume(raio);
Console.WriteLine($"Volume: {resultado}");

