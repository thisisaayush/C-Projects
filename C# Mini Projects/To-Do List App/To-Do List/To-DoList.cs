using System;

public class Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the to-do list program!");
			List<string> taskList = new List<string>;
			string option = "";

			while(option != "e")
			{
				Console.WriteLine("What would you like to do?");
				Console.WriteLine("Enter 1 to add a task to the list.");
				Console.WriteLine("Enter 2 to remove a task from the list.");
				Console.WriteLine("Enter 3 to view the list.");
				Console.WriteLine("Enter e to exit the program.");

				option = Console.ReadLine();

				if (option == "1")
				{
					Console.WriteLine("Enter the task name to add to the list: ");
					string task = Console.ReadLine();
					taskList.Add(task);

					Console.WriteLine(task + " is added to the to-do list.");
				}

				else if (option == "2")
				{
					for (int i = 0; i < taskList.Count; i++)
					{
						Console.WriteLine(i + ": " + taskList);
					}

					Console.WriteLine("Enter the number of the task to remove from the list: ");
					int taskNumber = Convert.ToInt32(Console.ReadLine());
					taskList.RemoveAt(taskNumber);
				}

				else if (option == "3")
				{
					Console.WriteLine("Current tasks in the list: ");

					for (int i = 0; i < taskList.Count; i++)
					{
						Console.WriteLine(taskList[i]);
					}
				}

				else if (option == "3")
			}
		}
	}
}
