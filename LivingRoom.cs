using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class LivingRoom : HabitableRoom
	{
		protected bool HasTV { get; set; } = false;
		public LivingRoom(int Id, int aArea, int aPeopleAmount, bool aHasTV)
		: base(Id, aArea, aPeopleAmount)
		{
			HasTV = aHasTV;
			PrintLog($"Room created with id: {Id} and area {aArea} and {aPeopleAmount} peoples inside with Tv {aHasTV}");
		}
		public new void PrintInfo()
		{
			Console.WriteLine("Living room Object");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Area: " + this.Area);
			Console.WriteLine("Amount of people: " + this.PeopleAmount);
			Console.WriteLine("Has TV? " + this.HasTV);
			Console.WriteLine();
		}
	}
}
