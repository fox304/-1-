using System;
Console.WriteLine("Введите расстояние между друзьями");
int dist = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
int speed_dog = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга");
int speed_first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга");
int speed_second = Convert.ToInt32(Console.ReadLine());
int count = 0;
float remaining_dist = dist;
int ahead = 0;
float time = 0;
while (remaining_dist > 10)
	if (ahead == 0)

	{
		time = remaining_dist / (speed_dog+speed_second);
		ahead++;
		//Console.WriteLine(remaining_dist);
	}
	else
	{
		time = remaining_dist / (speed_dog+speed_first);
		ahead--;
		//Console.WriteLine(remaining_dist);
	}
	remaining_dist = remaining_dist - time*(speed_first+speed_second);
	count++;
	Console.WriteLine(remaining_dist);

Console.WriteLine(count);

	