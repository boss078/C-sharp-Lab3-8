using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public delegate void MessageHandler(string message);
	class Room
	{
		protected int Id { get; private set; }
		public event MessageHandler PrintMessageEvent;

		protected int area;
		public int Area { get { return this.area; }
			set
			{
				if(value >= 0)
                {
					this.area = value;
					PrintMessage($"Area changed to {this.area}");
                }
				else
                {
					PrintMessage($"Area was not changed, because value={value} < 0");
				}
			}
		}
		public Room(int Id)
		{
			this.Id = Id;
			this.Area = 10;
		}
		public Room(int Id, int aArea)
		{
			this.Id = Id;
			Area = aArea;
		}
		public void PrintInfo()
		{
			Console.WriteLine("Room Object");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Id: " + this.Id);
			Console.WriteLine("Area: " + this.Area);
			Console.WriteLine();
		}
		public void PrintMessage(string message)
		{
			if (PrintMessageEvent != null)
			{
				Console.WriteLine("Message:");
				PrintMessageEvent.Invoke(message);
				Console.WriteLine("~~~~~~~~~~~~~~~~~~");
			}
		}
	}
}
