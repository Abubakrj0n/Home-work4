// See https://aka.ms/new-console-template for more information

Console.WriteLine("Рақами воҳиди массаро ворид кунед (1 — кг, 2 — мг, 3 — г, 4 — т, 5 — в):");
int vohid = int.Parse(Console.ReadLine());

Console.WriteLine("Вазни бадани худро дар воҳидҳои зерин ворид кунед:");
double massa = double.Parse(Console.ReadLine());

double massakilogram = 0;

switch (vohid)
{
    case 1: 
        massakilogram = massa;
        break;
    case 2: 
        massakilogram = massa * 0.000001;
        break;
    case 3: 
        massakilogram = massa * 0.001;
        break;
    case 4: 
        massakilogram = massa * 1000;
        break;
    case 5: 
        massakilogram = massa * 100;
        break;
    default:
        Console.WriteLine("Ошибка: номер единицы массы должен быть от 1 до 5.");
        return;
}

Console.WriteLine(massakilogram);