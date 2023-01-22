// See https://aka.ms/new-console-template for more information




    {
      List<string> employees = new List<string>() { "adam", "amy" };
      employees.Add("barbara");
      employees.Add("billy");
      employees.Add("Ian");
      employees.Remove("adam");
      Console.WriteLine("Please enter a name: ");
      // Get a name from the console and assign it to a variable
      string input = Console.ReadLine();
      employees.Add(input);
      for (int i = 0; i < employees.Count; i++) 
      {
        Console.WriteLine(employees[i]);
      }
    }