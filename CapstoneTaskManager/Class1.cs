using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTaskManager
{
    class Task
    {
        public static string GetUserChoice(string message, List<string> startMenu)
        {
            Console.WriteLine(message);
            string userChoice = "";
            bool cont = true;
            while (cont)
            {
                try
                {
                    int usrChoice = int.Parse(Console.ReadLine());
                    if (usrChoice >= 1 && usrChoice <= startMenu.Count )
                    {
                        userChoice = startMenu[usrChoice-1];
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input, please give a valid value.");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid response, please give a valid choice (1-5) and then press enter");
                    continue;
                }

            }
            return userChoice;
        }
        public static void ListTasks(List<string> tasks)
        {
            Options.PrintLists(tasks);
        }
        public static List<string> AddTask(List<string> tasks)
        {
            ;
            Console.WriteLine("Please input a task you would like to add to the task list");
            string newTask = Console.ReadLine();
            tasks.Add($"{newTask}");
            //need to give each new task a corresponding number
            return tasks;
        }
        public static List<string> DeleteTask(List<string> tasks)
        {
            Console.WriteLine("Please input the number corresponding to the task that you would like to delete");
            
            bool cont = true;
            while (cont)
            {
                try
                {
                    int usrInput = int.Parse(Console.ReadLine());
                    tasks.Remove(tasks[usrInput-1]);
                    cont = false;
                }
                catch
                {
                    Console.WriteLine("That is an invalid response, please give a number corresponding to the task you would like to delete.");
                }
            }
            return tasks;
        }
        public static List<string> FinishATask(List<string> finishedTasks, List<string> tasks)
        {
            Console.WriteLine("Please input the number corresponding to the task you completed");
            Options.PrintLists(tasks);
            bool cont = true;
            int usrInput = 0;
            while(cont)
            {
                try
                {
                    usrInput = int.Parse(Console.ReadLine());
                    string savedActivity = tasks[usrInput - 1];
                    finishedTasks.Add(savedActivity);
                    tasks.Remove(tasks[usrInput-1]);
                    cont = false;
                }
                catch
                {
                    Console.WriteLine("That was an invalid input, please give a number corresponding to a task and press enter.");
                }
            }
            return tasks;
        }
        public static string ChooseEmployee(string message, List<string> employeeNames)
        {
            Console.WriteLine(message);
            Options.PrintLists(employeeNames);
            string choosenEmployee = "";
            bool cont = true;
            while (cont)
            {
                string usrInput = Console.ReadLine();
                try
                {
                    int nameNum = int.Parse(usrInput)-1;
                    if(nameNum >=0 && nameNum <= employeeNames.Count - 1)
                    {
                        choosenEmployee = employeeNames[nameNum];
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number. Please input a number corresponding to an employee.");
                        continue;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("please give a number corresponding to the employee.");
                    continue;
                }
            }
            return choosenEmployee;
        }
        public static bool RepeatLoop(string message)
        {
            Console.WriteLine(message);
            bool result = true;
            bool cont = true;
            while(cont)
            {
                string usrInput = Console.ReadLine();
                if (usrInput == "y")
                {
                    result = true;
                    cont = false;
                }
                else if (usrInput == "n")
                {
                    result = false;
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Please input y or n");
                    continue;
                }
            }
            return result;
        }
        public static int ChooseAnInteraction(string message, List<string> startMenu)
        {
            Console.WriteLine(message);
            Options.PrintLists(startMenu);
            int usrNum = 0;
            bool cont = true;
            while (cont)
            {
                string usrInput = Console.ReadLine();
                try
                {
                    usrNum = int.Parse(usrInput)-1;
                    if(usrNum >= 0 && usrNum <= startMenu.Count-1)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input, please give a valid number and press enter");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("That is not a valid input, please give a valid number and press enter");
                    continue;
                }
            }
            return usrNum;
        }

    }
}
