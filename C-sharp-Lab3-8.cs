using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Room
	{ 
		protected int Id { get; private set; }
		protected delegate void PrintMessageAboutArea(string customMessage);
		protected event PrintMessageAboutArea PrintMessageEvent;
		public int Area { get; set; } = 10;
		public Room(int Id)
		{
			this.Id = Id;
			this.addListener();
		}
		public Room(int Id, int aArea)
		{
			this.Id = Id;
			Area = aArea;
			this.addListener();
		}
		protected void addListener()
		{
			PrintMessageAboutArea tmpDelegateInst = (string customMessage) => {
				Console.WriteLine("Room Object");
				Console.WriteLine("~~~~~~~~~~~~~~~~~~");
				Console.WriteLine("Id: " + this.Id);
				Console.WriteLine("Area: " + this.Area);
				Console.WriteLine("CustomMessage: " + customMessage);
				Console.WriteLine();
			};
			PrintMessageEvent += tmpDelegateInst;
		}
		public void ClearEvents()
		{
			this.PrintMessageEvent = null;
		}
		public void PrintInfo(string message)
		{
			PrintMessageEvent?.Invoke(message);
		}
	}

	class HabitableRoom : Room
	{
		protected int PeopleAmount { get; set; } = 1;

		public HabitableRoom(int Id, int aArea, int aPeopleAmount) : base(Id, aArea)
		{
			PeopleAmount = aPeopleAmount;
			this.addListener();
		}
		public new void addListener()
		{
			PrintMessageAboutArea tmpDelegateInst = delegate (string customMessage)
			{
				Console.WriteLine("Habitable room Object");
				Console.WriteLine("~~~~~~~~~~~~~~~~~~");
				Console.WriteLine("Id: " + this.Id);
				Console.WriteLine("Area: " + this.Area);
				Console.WriteLine("Amount of people: " + this.PeopleAmount);
				Console.WriteLine("CustomMessage: " + customMessage);
				Console.WriteLine();
			};
			this.ClearEvents();
			PrintMessageEvent += tmpDelegateInst;
		}
	}

	class LivingRoom : HabitableRoom
	{
		protected bool HasTV { get; set; } = false;
		public LivingRoom(int Id, int aArea, int aPeopleAmount, bool aHasTV) 
		: base(Id, aArea, aPeopleAmount)
		{
			HasTV = aHasTV;
			this.addListener();
		}
		public new void addListener()
		{
			PrintMessageAboutArea tmpDelegateInst = delegate (String customMessage)
			{
				Console.WriteLine("Living room Object");
				Console.WriteLine("~~~~~~~~~~~~~~~~~~");
				Console.WriteLine("Id: " + this.Id);
				Console.WriteLine("Area: " + this.Area);
				Console.WriteLine("Amount of people: " + this.PeopleAmount);
				Console.WriteLine("Has TV? " + this.HasTV);
				Console.WriteLine("CustomMessage: " + customMessage);
				Console.WriteLine();
			};
			this.ClearEvents();
			PrintMessageEvent += tmpDelegateInst;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			LivingRoom livingRoom1 = new LivingRoom(rnd.Next(), 40, 2, true);
			LivingRoom livingRoom2 = new LivingRoom(rnd.Next(), 23, 1, false);
			LivingRoom livingRoom3 = new LivingRoom(rnd.Next(), 422, 10, true);
			LivingRoom livingRoom4 = new LivingRoom(rnd.Next(), 5, 0, false);
			livingRoom1.PrintInfo("livingRoom1Message");
			livingRoom2.PrintInfo("livingRoom2Message");
			livingRoom3.PrintInfo("livingRoom3Message");
			livingRoom4.PrintInfo("livingRoom4Message");
			Console.ReadKey(true);
		}
	}
}
