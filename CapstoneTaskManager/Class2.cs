using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTaskManager
{
    class Options
    {
        public static void KelseyOption(string message, int interactionChoice, List<string> kelseyTasks, List<string> kelseyCompletedTasks)//rename to correct naming convention (verb first)
        {
            //idk if returning anything is useful
            Console.WriteLine(message);
            Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");
            switch (interactionChoice)
            {
                case (1):
                    Task.ListTasks(kelseyTasks);
                    Console.WriteLine(kelseyTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    kelseyTasks = Task.AddTask(kelseyTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kelsey's new task list is: \n{kelseyTasks}");
                    break;
                case (3):
                    kelseyTasks = Task.DeleteTask(kelseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{kelseyTasks}");
                    break;
                case (4):
                    kelseyCompletedTasks = Task.FinishATask(kelseyCompletedTasks, kelseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{kelseyTasks}");
                    Console.WriteLine($"Kelsey's new completed task list is: \n{kelseyCompletedTasks}");
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void BobOption(string message, int interactionChoice, List<string> bobTasks, List<string> bobCompletedTasks)//rename to correct naming convention (verb first)
        {
            //idk if returning anything is useful
            Console.WriteLine(message);
            Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");
            switch (interactionChoice)
            {
                case (1):
                    Task.ListTasks(bobTasks);
                    Console.WriteLine(bobTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    bobTasks = Task.AddTask(bobTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kelsey's new task list is: \n{bobTasks}");
                    break;
                case (3):
                    bobTasks = Task.DeleteTask(bobTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{bobTasks}");
                    break;
                case (4):
                    bobCompletedTasks = Task.FinishATask(bobCompletedTasks, bobTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{bobTasks}");
                    Console.WriteLine($"Kelsey's new completed task list is: \n{bobCompletedTasks}");
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void CaseyOption(string message, int interactionChoice, List<string> caseyTasks, List<string> caseyCompletedTasks)//rename to correct naming convention (verb first)
        {
            //idk if returning anything is useful
            Console.WriteLine(message);
            Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");
            switch (interactionChoice)
            {
                case (1):
                    Task.ListTasks(caseyTasks);
                    Console.WriteLine(caseyTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    caseyTasks = Task.AddTask(caseyTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kelsey's new task list is: \n{caseyTasks}");
                    break;
                case (3):
                    caseyTasks = Task.DeleteTask(caseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{caseyTasks}");
                    break;
                case (4):
                    caseyCompletedTasks = Task.FinishATask(caseyCompletedTasks, caseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{caseyTasks}");
                    Console.WriteLine($"Kelsey's new completed task list is: \n{caseyCompletedTasks}");
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void KyleOption(string message, int interactionChoice, List<string> kyleTasks, List<string> kyleCompletedTasks)//rename to correct naming convention (verb first)
        {
            //idk if returning anything is useful
            Console.WriteLine(message);
            Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");
            switch (interactionChoice)
            {
                case (1):
                    Task.ListTasks(kyleTasks);
                    Console.WriteLine(kyleTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    kyleTasks = Task.AddTask(kyleTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kelsey's new task list is: \n{kyleTasks}");
                    break;
                case (3):
                    kyleTasks = Task.DeleteTask(kyleTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{kyleTasks}");
                    break;
                case (4):
                    kyleCompletedTasks = Task.FinishATask(kyleCompletedTasks, kyleTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{kyleTasks}");
                    Console.WriteLine($"Kelsey's new completed task list is: \n{kyleCompletedTasks}");
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void SteveOption(string message, int interactionChoice, List<string> steveTasks, List<string> steveCompletedTasks)//rename to correct naming convention (verb first)
        {
            //idk if returning anything is useful
            Console.WriteLine(message);
            Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");
            switch (interactionChoice)
            {
                case (1):
                    Task.ListTasks(steveTasks);
                    Console.WriteLine(steveTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    steveTasks = Task.AddTask(steveTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kelsey's new task list is: \n{steveTasks}");
                    break;
                case (3):
                    steveTasks = Task.DeleteTask(steveTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{steveTasks}");
                    break;
                case (4):
                    steveCompletedTasks = Task.FinishATask(steveCompletedTasks, steveTasks);
                    Console.WriteLine($"Kelsey's new task list is: \n{steveTasks}");
                    Console.WriteLine($"Kelsey's new completed task list is: \n{steveCompletedTasks}");
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }


    }
}
