﻿/* На следующем этапе предлагаю вам создать новое приложение: показать на экране частное двух чисел.
Казалось бы, что может быть проще: заменить плюс на деления, и вроде бы всё. Но попробуем сделать
это и убедиться, что всё не так просто, как кажется.*/

//int numberA = 15;
//int numberB = 3;
//Console.WriteLine(numberA / numberB);

/* Целые и вещественные числа
Попробуем внести небольшие правки. Я изменю значение numberA с 10 на 12. Что будет, если 12
разделить на 5? Перезапускаем и снова получаем 2, хотя по всем правилам должно получиться 2,4.

int numberA = 12;
int numberB = 5;
Console.WriteLine(numberA / numberB);

PK@DESKTOP-V3A9FLJ MINGW64 /c/GeekBrains/Знакомство с яз-ми про-я/C#_lesson1/divisionTwoNumbers (main)
$ dotnet run
2

Почему мы получили именно такой результат? Дело в том, что, мы работаем в целых числах. Если вы
помните, в модуле математики и информатики мы обсуждали деление в целых числах. Здесь мы увидели
реальный пример.
Поправим наше приложение, чтобы было деление. Для этого нужно контейнер «integer» (целое число)
заменить на контейнер «double», позволяющий работать с вещественными числами. */

double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA / numberB);

// $ dotnet run
// 2,4

/* Перезапускаем проект и видим на экране 2,4 — тот результат, который и должны были получить. Всё
хорошо. Теперь приложение нужно запушить. Вводим в терминале git commit -a и добавляем
комментарий dd Example 004 Div. Далее вводим git push origin main. Готово! У нас есть 4 проекта.
Продолжим изучение языка С#. */


 


