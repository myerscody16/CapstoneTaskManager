using System;
using System.Collections.Generic;


namespace CapstoneTaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List and Variable initialization
            List<string> employeeNames = new List<string> { "1. Kelsey", "2. Bob", "3. Casey", "4. Kyle", "5. Steve" };
            List<string> startMenu = new List<string> { "1. List tasks", "2. Add task", "3. Delete task","4. Mark test complete", "5. Quit"};
            List<string> kelseyTasks = new List<string> { "Let the dogs out", "Feed the dogs","Buy new shoes", "Clean the car", "Clean room" };
            List<string> bobTasks = new List<string> { "Let the dogs out", "Feed the dogs", "Buy new shoes", "Clean the car", "Clean room" };
            List<string> caseyTasks = new List<string> { "Let the dogs out", "Feed the dogs", "Buy new shoes", "Clean the car", "Clean room" };
            List<string> kyleTasks = new List<string> { "Let the dogs out", "Feed the dogs", "Buy new shoes", "Clean the car", "Clean room" };
            List<string> steveTasks = new List<string> { "Let the dogs out", "Feed the dogs", "Buy new shoes", "Clean the car", "Clean room" };
            List<string> kelseyCompletedTasks = new List<string> { };
            List<string> bobCompletedTasks = new List<string> { };
            List<string> caseyCompletedTasks = new List<string> { };
            List<string> kyleCompletedTasks = new List<string> { };
            List<string> steveCompletedTasks = new List<string> { };
            string usrChoice = "";
            bool cont = true;
            bool cont1 = true;
            #endregion
            while (cont)
            {
                while (cont1)
                {
                    //input
                    //prompt
                    Console.WriteLine("Welcome to the Task Manager!");
                    //find which employee they want to interact with
                    string choosenEmployee = Task.ChooseEmployee("which employee's task list would you like to interact with? \nPlease input their number and press enter", employeeNames);
                    //ask how they want to interact with the list
                    //save the number that they entered and give it to "some name"Option();
                    int interactionChoice = Task.ChooseAnInteraction($"How would you like to interact with {choosenEmployee}'s task list? Please input the number that corresponds to the interaction", startMenu);
                    switch (choosenEmployee)
                    {
                        case ("Kelsey"):
                            Options.KelseyOption("What would you like to do? Please use the number to select the option.", interactionChoice, kelseyTasks, kelseyCompletedTasks);
                            break;
                        case ("Bob"):
                            Options.BobOption("What would you like to do? Please use the number to select the option.", interactionChoice, bobTasks, bobCompletedTasks);
                            break;
                        case ("Casey"):
                            Options.CaseyOption("What would you like to do? Please use the number to select the option.", interactionChoice, caseyTasks, caseyCompletedTasks);
                            break;
                        case ("Kyle"):
                            Options.KyleOption("What would you like to do? Please use the number to select the option.", interactionChoice, kyleTasks, kyleCompletedTasks);
                            break;
                        case ("Steve"):
                            Options.SteveOption("What would you like to do? Please use the number to select the option.", interactionChoice, steveTasks, steveCompletedTasks);
                            break;
                    }
                    //interact with the employee's list
                    Console.WriteLine("1. List tasks \n 2. Add task \n 3. Delete task \n 4. Mark tast complete \n 5. Quit");

                    cont1 = Task.RepeatLoop("\nWould you like to further interact with an employee's task lists? (y/n)");
                }
                cont = Task.RepeatLoop("\nWould you like to interact with another employee's task lists? (y/n)");
            }
        }
    }
}
