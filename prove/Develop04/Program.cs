using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int choice;

            while (!quit)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                
                if (choice == 1)
                {
                    string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breath1 = new BreathingActivity("Breathing", description , -1);
                    breath1.Run();
                }
                else if (choice == 2)
                {
                    string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflect1 = new ReflectingActivity("Reflecting", description, -1);
                    reflect1.Run();
                }
                else if (choice == 3)
                {
                    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity list1 = new ListingActivity("Listing", description, -1);
                    list1.Run();         
                }
                else if (choice == 4)
                {
                    quit = true;
                }
            }
    }
    
}