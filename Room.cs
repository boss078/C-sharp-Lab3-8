using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public delegate void LogHandler();
	class Room
	{
		protected int Id { get; private set; }
		public event LogHandler PrintLogEvent;

		public int Area { get; set; } = 10;
		public Room(int Id)
		{
			this.Id = Id;
			PrintLogEvent += new LogHandler(() => { Console.WriteLine("Created room object with id " + this.Id); });
		}
		public Room(int Id, int aArea)
		{
			this.Id = Id;
			Area = aArea;
			PrintLogEvent += new LogHandler(() => {
				Console.WriteLine("Created room object with id "
					+ this.Id + " and area " + this.Area);
			});
		}
		public void PrintInfo()
		{
			Console.WriteLine("Room Object");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Area: " + this.Area);
			Console.WriteLine();
		}
		public void PrintLog()
		{
			Console.WriteLine("Logs:");
			PrintLogEvent?.Invoke();
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
		}
	}
}
