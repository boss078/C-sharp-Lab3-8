using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void printMessageToConsole(string message)
        {
			Console.WriteLine(message);
        }
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Room room = new Room(rnd.Next(1000), 40);
			HabitableRoom habitableRoom = new HabitableRoom(rnd.Next(1000), 23, 1);
			LivingRoom livingRoom = new LivingRoom(rnd.Next(1000), 422, 10, true);
			room.PrintMessageEvent += printMessageToConsole;
			habitableRoom.PrintMessageEvent += printMessageToConsole;
			livingRoom.PrintMessageEvent += printMessageToConsole;
			room.PrintInfo();
			room.Area = 15;
			room.Area = -4;
			room.PrintInfo();
			habitableRoom.PrintInfo();
			habitableRoom.PeopleAmount = 5;
			habitableRoom.PeopleAmount = -3;
			habitableRoom.PrintInfo();
			livingRoom.PrintInfo();
			livingRoom.HasTV = false;
			livingRoom.Area = -2;
			livingRoom.PrintInfo();
			Console.ReadKey(true);
		}
	}
}
