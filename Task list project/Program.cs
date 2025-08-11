internal class Program
{
  static void Main(string[] args)
  {
    string[] tasksList = new string[4];
    
    bool isRunning = true;
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
      int.TryParse(input, out int choice);
      Console.WriteLine();

      if(choice <= 5)
      {
        switch(choice)
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
      else
      {
        Console.WriteLine("Invalid choice, please try again.");
      }
    }

    void addTask()
    {
      Console.Clear();
      Console.WriteLine("addTask function");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    void removeTask()
    {
      Console.Clear();
      Console.WriteLine("removeTask function");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    void markCompleted()
    {
      Console.Clear();
      Console.WriteLine("markCompleted function");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }

    void showTasks()
    {
      Console.Clear();
      Console.WriteLine("showTasks function");
      Console.WriteLine();
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }
  }
}