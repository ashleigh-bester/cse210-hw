using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Formats.Asn1;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        int answer;

        PromptGenerator prompt1 = new PromptGenerator();
        Journal journal1 = new Journal();

        while (!exit)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                //Get the date from user or from DateTime
                Console.Write("Date: ");
                string _date = Console.ReadLine();
                //Get prompt
                string _prompts = prompt1.GetRandomPrompt();
                Console.WriteLine($"{_prompts}");
                //Get entry from user
                Console.WriteLine("Start typing...");
                Console.Write("");
                string _entryText = Console.ReadLine();
                //Add new entry to journal

            }
            else if (answer == 2)
            {
                Console.WriteLine("Entry");
                Console.WriteLine();
                /*Entry entry1 = Entry entry1 = new Entry(_date, _prompts, _entryText);
                Console.WriteLine(entry1.Display());*/
            }
            else if (answer == 3)
            {

            }
            else if (answer == 4)
            {

            }
            else if (answer == 5)
            {
                exit = true;
            }
        }


        /*PromptGenerator prompt1 = new PromptGenerator();
        prompt1._prompts.Add("The high of my day!");

        PromptGenerator prompt2 = new PromptGenerator();
        prompt2._prompts.Add("A tender mercy or blessing I've experienced today.");
        
        PromptGenerator prompt3 = new PromptGenerator();
        prompt3._prompts.Add("Something that made me smile/laugh today.");

        PromptGenerator prompt4 = new PromptGenerator();
        prompt4._prompts.Add("3 things that I want to improve on.");

        PromptGenerator prompt5 = new PromptGenerator();
        prompt5._prompts.Add("What project am I working on that brings me joy?");

        Console.WriteLine(prompt1._prompts); */
    }
}