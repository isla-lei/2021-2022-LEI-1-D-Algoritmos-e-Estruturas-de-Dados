// See https://aka.ms/new-console-template for more information


// 10.Escreva um procedimento que imprima a
// data recebida em 3 parâmetros inteiros DD, MM e AAAA
// na forma “DD de Nome do mês de AAAA”.
// Exemplo: FormataData(29, 3, 2022) - Escreve: 29 de março de 2022

string MesExtenso(int mesNumero)
{
    string mes = "";
    switch (mesNumero)
    {
        case 1:
            mes = "janeiro";
            break;
        case 2:
            mes = "fevereiro";
            break;
        case 3:
            mes = "março";
            break;
        case 4:
            mes = "abril";
            break;
        case 5:
            mes = "maio";
            break;
        case 6:
            mes = "junho";
            break;
        case 7:
            mes = "julho";
            break;
        case 8:
            mes = "agosto";
            break;
        case 9:
            mes = "setmbro";
            break;
        case 10:
            mes = "outubro";
            break;
        case 11:
            mes = "novembro";
            break;
        case 12:
            mes = "dezembro";
            break;
        default:
            mes = "Mês inválido!";
            break;
    }
    return mes;
}

string MesExtenso2(int mesNumero)
{
    string[] meses = { "jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "out", "nov", "dez" };

    string mes = String.Empty; // = ""
    if (mesNumero < 1 || mesNumero > 12)
    {
        mes = "Mês inválido!";
    }
    else
    {
        mes = meses[mesNumero - 1];
    }
    return mes;
}


void FormataData(int dd, int mm, int aaaa)
{
    string mes = MesExtenso(mm);
    // exemplo de saída: 29 de março de 2022
    Console.WriteLine($"{dd} de {mes} de {aaaa}");
}


// Main
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

FormataData(29, 3, 2022);

Console.Write("Dia........: ");
int dia = int.Parse(Console.ReadLine());

Console.Write("Mês Numero.: ");
int mes = int.Parse(Console.ReadLine());

Console.Write("Ano........: ");
int ano = int.Parse(Console.ReadLine());

FormataData(dia, mes, ano);