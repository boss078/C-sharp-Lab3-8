using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class HabitableRoom : Room
	{
		protected int PeopleAmount { get; set; } = 1;

		public HabitableRoom(int Id, int aArea, int aPeopleAmount) : base(Id, aArea)
		{
			PeopleAmount = aPeopleAmount;
			PrintLog($"Room created with id: {Id} and area {aArea} and {aPeopleAmount} peoples inside");
		}
		public new void PrintInfo()
		{
			Console.WriteLine("Habitable room Object");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Area: " + this.Area);
			Console.WriteLine("Amount of people: " + this.PeopleAmount);
			Console.WriteLine();
		}
	}
}
