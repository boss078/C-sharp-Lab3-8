using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class HabitableRoom : Room
	{
		protected int peopleAmount;
		public int PeopleAmount {
			get { return this.peopleAmount; }
			set
			{
				if (value >= 0)
				{
					this.peopleAmount = value;
					PrintMessage($"People amount changed to {this.peopleAmount}");
				}
				else
				{
					PrintMessage($"People amount was not changed, because value={value} < 0");
				}
			}
		}

		public HabitableRoom(int Id, int aArea, int aPeopleAmount) : base(Id, aArea)
		{
			PeopleAmount = aPeopleAmount;
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
