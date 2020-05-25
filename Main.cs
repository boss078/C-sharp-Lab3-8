using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Room room1 = new Room(rnd.Next(1000), 40);
			HabitableRoom habitableRoom1 = new HabitableRoom(rnd.Next(1000), 23, 1);
			LivingRoom livingRoom1 = new LivingRoom(rnd.Next(1000), 422, 10, true);
			LivingRoom livingRoom2 = new LivingRoom(rnd.Next(1000), 5, 0, false);
			room1.PrintInfo();
			room1.PrintLog();
			habitableRoom1.PrintInfo();
			habitableRoom1.PrintLog();
			livingRoom1.PrintInfo();
			livingRoom1.PrintLog();
			livingRoom2.PrintInfo();
			livingRoom2.PrintLog();
			Console.ReadKey(true);
		}
	}
}
