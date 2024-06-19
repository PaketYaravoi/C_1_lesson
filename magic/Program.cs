/*Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("$"); */

int xa = 10;
int ya = 5;

int xb = 1;
int yb = 15;

int xc = 20;
int yc = 15;

/* int xa= 1, ya=1,
       xb= 2, yb=2,
       xc=4, yc =5;
       пример сокращения кода 

Console.SetCursorPosition(xa, ya);
Console.WriteLine("№");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("$");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("$"); */

int x = xa;
int y = ya;

int count = 0;

while(count < 400)
{
    int num = new Random().Next(0, 3); // [0;3) 0 1 2
    if(num == 0 )
    {
        x = ( x + xa) / 2;
        y = ( y + ya) / 2;
    }
    if(num == 1)
    {
        x = ( x + xb) / 2;
        y = ( y + yb) / 2;
    }
    if(num == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x , y);
    Console.WriteLine("*");
    count ++;

}
