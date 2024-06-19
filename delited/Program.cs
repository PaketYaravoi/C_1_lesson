using System;

class Program
{
    static void Main()
    {
        // Устанавливаем координаты точек
        int xa = 1;
        int ya = 1;

        int xb = 1;
        int yb = 15;

        int xc = 15;
        int yc = 40;

        // Увеличиваем размер окна и буфера консоли, если требуется
        Console.SetWindowSize(150, 50);
        Console.SetBufferSize(150, 50);

        // Устанавливаем позиции курсора и выводим точки
        Console.SetCursorPosition(xa, ya);
        Console.WriteLine("+");

        Console.SetCursorPosition(xb, yb);
        Console.WriteLine("+");

        Console.SetCursorPosition(xc, yc);
        Console.WriteLine("+");

        // Для удержания окна открытым, чтобы увидеть результат
        Console.ReadKey();
    }
}
