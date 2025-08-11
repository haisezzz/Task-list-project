internal class Program
{
  static void Main(string[] args)
  {
    List<string> todoList = new List<string>();  // list to hold tasks

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
      Console.WriteLine("removeTask function");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
    }

    void markCompleted()
    {
      Console.Clear();
      Console.WriteLine("markCompleted function");
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
      }
      Console.WriteLine();
      Console.WriteLine("Press any key to continue.");
      Console.ReadKey();
    }
  }
}