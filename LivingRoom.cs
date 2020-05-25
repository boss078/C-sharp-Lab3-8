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
			PrintLogEvent += new LogHandler(() =>
			{
				if (this.HasTV)
					Console.WriteLine("Created living room object with id " + this.Id + " and area "
						+ this.Area + " and " + this.PeopleAmount + " people and TV inside");
				else
					Console.WriteLine("Created living room object with id " + this.Id + " and area "
						+ this.Area + " and " + this.PeopleAmount + " people and without any TV inside");
			});
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
