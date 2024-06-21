/*
 Задача с собакой и друзьями:
Два друга движутся навстречу с заданной скоростью. 
Скорость первого — 1 м/с 
второго —2 м/с. 
У них есть собака, которая бегает со скоростью 5 м/с. 
Когда друзья начинают свой путь, собака бежит от одного друга к другому, добегает, разворачивается и тут же бежит обратно.

Сколько раз собака перебежит от одного друга к другому, пока они не встретятся?

S — расстояние

V — скорость

T — время

V = S ÷ T

S = V × T

T = S ÷ V

*/
int count = 0;
int frend = 2;
int distance = 10000;
int firstFriednSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time = 0;

while(distance > 10)
{
    if(frend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        distance = distance- (secondFriendSpeed + firstFriednSpeed) * time;
        frend =1;
        count ++;
    }
    else if(frend ==1)
    {
        time = distance / (firstFriednSpeed + dogSpeed);
        distance = distance - (secondFriendSpeed + firstFriednSpeed) * time;
        frend = 2;
        count ++;
    }
    Console.Write("Количество пробежек: ");
    Console.WriteLine(count);
    Console.Write("Какая дистанция осталась: ");
    Console.WriteLine(distance);
}
Console.WriteLine(count);