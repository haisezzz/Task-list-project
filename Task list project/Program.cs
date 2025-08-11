internal class Program
{
  static void Main(string[] args)
  {
    List<string> todoList = new List<string>();  // list to hold tasks
    List<string> completedList = new List<string>();  // list to hold completed tasks

    bool isRunning = true;  // main loop
    while(isRunning)
    {
      Console.Clear();
      Console.WriteLine("Welcome to the What Should My Husband Do Today app!");
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
      Console.WriteLine("Please select an optiom:");
      Console.WriteLine("1. Give him a new task");
      Console.WriteLine("2. Remove a task");
      Console.WriteLine("3. Mark a task as done");
      Console.WriteLine("4. Show all tasks");
      Console.WriteLine("5. Exit the app");
      Console.WriteLine();
      string? input = Console.ReadLine();
      int.TryParse(input, out int choice);  // parse input to int
      Console.WriteLine();

      if(choice <= 5)  // check if choice is valid
      {
        switch(choice)  // call methods based on choice
        {
          case 1:
            addTask();
            break;
          case 2:
            removeTask();
            break;
          case 3:
            markCompleted();
            break;
          case 4:
            showTasks();
            break;
          case 5:
            isRunning = false;
            Console.WriteLine("Thank you for using the app! Byebye!");
            break;
        }
      }
      else  // if choice is not valid
      {
        Console.WriteLine("Invalid choice, please try again.");
        Thread.Sleep(1500);
      }
    }

    void addTask()
    {
      Console.Clear();
      Console.WriteLine("Write down a new task:");
      Console.WriteLine();
      if(todoList.Count > 5)  // check if there are too many tasks
      {
        Console.WriteLine("Husband has too many tasks already, tell him to finish some first! (Or remove one yourself)");
      }
      else
      {
        string? task = Console.ReadLine();
        task = char.ToUpper(task![0]) + task.Substring(1).ToLower();  // cap the first letter lowercase the rest
        todoList.Add(task!);
        Console.WriteLine();
        Console.WriteLine($"Task added successfully!");
      }
      Console.WriteLine("Press any key to go back to main menu.");
      Console.ReadKey();
    }

    void removeTask()
    {
      Console.Clear();
      Console.WriteLine("Which task would you like to remove?");
      for(int i = 0; i < todoList.Count; i++)  // loop through tasks
      {
        Console.Write($"{i + 1}. ");  // display task number before changing task color
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(todoList[i]);
        Console.ResetColor();
      }
      Console.WriteLine();
      string? choice = Console.ReadLine();
      int.TryParse(choice, out int taskNumber);
      if(taskNumber > 0 && taskNumber <= todoList.Count)  // check if choice is valid
      {
        todoList.RemoveAt(taskNumber - 1);  // -1 because list is 0-indexed
        Console.WriteLine();
        Console.WriteLine($"Task {taskNumber} removed successfully!");
      }
      else
      {
        Console.WriteLine("Invalid task number, please try again.");
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
    }

    void markCompleted()
    {
      Console.Clear();
      Console.WriteLine("Which task would you like to mark as done?");
      for(int i = 0; i < todoList.Count; i++)  // loop through tasks
      {
        Console.Write($"{i + 1}. ");  // display number before changing task color
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(todoList[i]);
        Console.ResetColor();
      }
      Console.WriteLine();
      string? choice = Console.ReadLine();
      int.TryParse(choice,out int taskNumber);

      if(taskNumber > 0 && taskNumber <= todoList.Count)  // check if choice is valid
      {
        string completedTask = todoList[taskNumber - 1];

        Console.WriteLine();
        Console.WriteLine($"Task {taskNumber} marked as done!");

        todoList.RemoveAt(taskNumber - 1);  // remove task from todo list

        completedList.Add(completedTask.ToLower());  // make task lowercase and add to completed list
      }
      else
      {
        Console.WriteLine("Invalid task number, please try again.");
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
    }

    void showTasks()
    {
      Console.Clear();
      Console.WriteLine("Current tasks:");
      if(todoList.Count == 0)
      {
        Console.WriteLine("No tasks available! Maybe add one so he doesn't get too lazy...");
      }
      for(int i = 0; i < todoList.Count; i++)  // loop through tasks
      {
        Console.Write($"{i + 1}. ");

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(todoList[i]);

        Console.ResetColor();

        if(completedList.Count > 0)  // if there are completed tasks
        {
          Console.WriteLine();
          Console.WriteLine("Completed tasks:");
          for(int j = 0; j < completedList.Count; j++)  // loop through completed tasks
          {
            Console.Write($"- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(completedList[j]);
            Console.ResetColor();
          }
          Console.WriteLine();
        }
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
    }
  }
}