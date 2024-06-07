using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        bool quit = false;
        int choice;

        while (!quit)
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal simple = new SimpleGoal("", "", 0);
                }
                if (goalType == 2)
                {
                    EternalGoal eternal = new EternalGoal("", "", 0);
                }
                if (goalType == 3)
                {
                    ChecklistGoal checklist = new ChecklistGoal("", "", 0, 0, 0);
                }
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                quit = true;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        List<string> names = new List<string>();
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}