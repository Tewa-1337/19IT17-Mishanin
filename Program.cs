using System;

namespace ConsoleApp1
{
	class Program
	{
		/*Задание:
		R минимально, R кратно 21 ,если такого числа нет вывести - 1*/
		static void Main(string[] args)
		{

			{
				Random rand = new Random(); //рандома
				int[] massive = new int[1000]; //массива
				for (int i = 0; i < 1000; i++) //цикл от 0 до 10000 заполнен рандомными числами
				{
					massive[i] = rand.Next(0, 10000);
					Console.WriteLine(massive[i]);
				}
				int R = massive[0];
				Console.WriteLine("Минимальное число: ");
				for (int i = 0; i < massive.Length; i++) //поиск минимально массива и присвоение его R
				{
					if (massive[i] < R) { R = massive[i]; }
					
				}
				Console.WriteLine(R);
				Console.WriteLine("Условие: ");
				/*условие если R кратно 21 и является произведением двух случайных чисел массива) 
				если верно выводится R, если не верно выводится -1 */
				if ((R % 21 == 0) && (R == ((massive[new Random().Next(0, massive.Length)]) * (massive[new Random().Next(0, massive.Length)]))))
				{
					Console.WriteLine(R);
				}
				else 
				{ 
					Console.WriteLine("-1"); 
				}
			}
		}
	}
}
