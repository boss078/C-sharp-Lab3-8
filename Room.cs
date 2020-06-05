using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public delegate void LogHandler(string message);
	class Room
	{
		protected int Id { get; private set; }
		public event LogHandler PrintLogEvent;

		public int Area { get; set; } = 10;
		public Room(int Id)
		{
			this.Id = Id;
			PrintLog($"Room created with id: {Id}");
		}
		public Room(int Id, int aArea)
		{
			this.Id = Id;
			Area = aArea;
			PrintLog($"Room created with id: {Id} and area {aArea}");
		}
		public void PrintInfo()
		{
			Console.WriteLine("Room Object");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Area: " + this.Area);
			Console.WriteLine();
		}
		public void PrintLog(string message)
		{
			Console.WriteLine("Logs:");
			PrintLogEvent?.Invoke(message);
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
		}
	}
}
