using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTaskManager
{
    class Options
    {
        public static void KelseyOption(string message, int interactionChoice, List<string> kelseyTasks, List<string> kelseyCompletedTasks)//rename to correct naming convention (verb first)
        {
            switch (interactionChoice+1)
            {
                case (1):
                    Task.ListTasks(kelseyTasks);
                    PrintLists(kelseyTasks);
                    break;
                case (2):
                    kelseyTasks = Task.AddTask(kelseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: ");
                    PrintLists(kelseyTasks);
                    break;
                case (3):
                    PrintLists(kelseyTasks);
                    kelseyTasks = Task.DeleteTask(kelseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: ");
                    PrintLists(kelseyTasks);
                    break;
                case (4):
                    PrintLists(kelseyTasks);
                    kelseyCompletedTasks = Task.FinishATask(kelseyCompletedTasks, kelseyTasks);
                    Console.WriteLine($"Kelsey's new task list is: ");
                    PrintLists(kelseyTasks);
                    Console.WriteLine($"Kelsey's new completed task list is: ");
                    PrintLists(kelseyCompletedTasks);
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void BobOption(string message, int interactionChoice, List<string> bobTasks, List<string> bobCompletedTasks)//rename to correct naming convention (verb first)
        {
            switch (interactionChoice+1)
            {
                case (1):
                    Task.ListTasks(bobTasks);
                    PrintLists(bobTasks);
                    break;
                case (2):
                    bobTasks = Task.AddTask(bobTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Bob's new task list is: ");
                    PrintLists(bobTasks);
                    break;
                case (3):
                    PrintLists(bobTasks);
                    bobTasks = Task.DeleteTask(bobTasks);
                    Console.WriteLine($"Bob's new task list is: ");
                    PrintLists(bobTasks);
                    break;
                case (4):
                    PrintLists(bobTasks);
                    bobCompletedTasks = Task.FinishATask(bobCompletedTasks, bobTasks);
                    Console.WriteLine($"Bob's new task list is: ");
                    PrintLists(bobTasks);
                    Console.WriteLine($"Bob's new completed task list is: ");
                    PrintLists(bobCompletedTasks);
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void CaseyOption(string message, int interactionChoice, List<string> caseyTasks, List<string> caseyCompletedTasks)//rename to correct naming convention (verb first)
        {
            switch (interactionChoice+1)
            {
                case (1):
                    Task.ListTasks(caseyTasks);
                    break;
                case (2):
                    caseyTasks = Task.AddTask(caseyTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Casey's new task list is: ");
                    PrintLists(caseyTasks);
                    break;
                case (3):
                    PrintLists(caseyTasks);
                    caseyTasks = Task.DeleteTask(caseyTasks);
                    Console.WriteLine($"Casey's new task list is: ");
                    PrintLists(caseyTasks);
                    break;
                case (4):
                    PrintLists(caseyTasks);
                    caseyCompletedTasks = Task.FinishATask(caseyCompletedTasks, caseyTasks);
                    Console.WriteLine($"\nCasey's new task list is: ");
                    PrintLists(caseyTasks);
                    Console.WriteLine($"\nCasey's new completed task list is: ");
                    PrintLists(caseyCompletedTasks);
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
            switch (interactionChoice+1)
            {
                case (1):
                    Task.ListTasks(kyleTasks);
                    PrintLists(kyleTasks);
                    break;
                case (2):
                    kyleTasks = Task.AddTask(kyleTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Kyle's new task list is: ");
                    PrintLists(kyleTasks);
                    break;
                case (3):
                    PrintLists(kyleTasks);
                    kyleTasks = Task.DeleteTask(kyleTasks);
                    Console.WriteLine($"Kyle's new task list is: ");
                    PrintLists(kyleTasks);
                    break;
                case (4):
                    PrintLists(kyleTasks);
                    kyleCompletedTasks = Task.FinishATask(kyleCompletedTasks, kyleTasks);
                    Console.WriteLine($"Kyle's new task list is: ");
                    PrintLists(kyleTasks);
                    Console.WriteLine($"Kyle's new completed task list is: ");
                    PrintLists(kyleCompletedTasks);
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void SteveOption(string message, int interactionChoice, List<string> steveTasks, List<string> steveCompletedTasks)//rename to correct naming convention (verb first)
        {
            switch (interactionChoice+1)
            {
                case (1):
                    Task.ListTasks(steveTasks);
                    Console.WriteLine(steveTasks);
                    break;
                case (2):
                    //figure out which employee's task list needs to be added to the choose their task list to add to
                    steveTasks = Task.AddTask(steveTasks);//double check that this is  doing what it is supposed to
                    Console.WriteLine($"Steve's new task list: ");
                    PrintLists(steveTasks);
                    break;
                case (3):
                    PrintLists(steveTasks);
                    steveTasks = Task.DeleteTask(steveTasks);
                    Console.WriteLine($"Steve's new task list: ");
                    PrintLists(steveTasks);
                    break;
                case (4):
                    PrintLists(steveTasks);
                    steveCompletedTasks = Task.FinishATask(steveCompletedTasks, steveTasks);
                    Console.WriteLine("Steve's new task list: ");
                    PrintLists(steveTasks);
                    Console.WriteLine($"Steve's new completed task list:");
                    PrintLists(steveCompletedTasks);
                    break;
                case (5):
                    Console.WriteLine("Goodbye.");
                    System.Environment.Exit(0);
                    break;
            }
        }
        public static void PrintLists(List<string> list)
        {
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }


    }
}
