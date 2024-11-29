// See https://aka.ms/new-console-template for more information
Console.WriteLine("Рақами воҳиди дарозиро ворид кунед (1 — дм, 2 — км, 3 — м, 4 — мм, 5 — см):");
int vohid = int.Parse(Console.ReadLine());

Console.WriteLine("Дарозии сегментро дар воҳидҳои муқарраршуда ворид кунед:");
double darozi = double.Parse(Console.ReadLine());

double lengthInMeters = 0;

switch (vohid)
{
    case 1: 
        lengthInMeters = darozi * 0.1;
        break;
    case 2: 
        lengthInMeters = darozi * 1000;
        break;
    case 3: 
        lengthInMeters = darozi;
        break;
    case 4: 
        lengthInMeters = darozi * 0.001;
        break;
    case 5: 
        lengthInMeters = darozi * 0.01;
        break;
    default:
        Console.WriteLine("Хатогӣ: Рақами воҳиди дарозӣ бояд аз 1 то 5 бошад.");
        return;
}

Console.WriteLine($"Длина отрезка в метрах: {lengthInMeters}");
