using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menus for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method execute until the user inputs something to exit to main menu.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            var EnteringData = true;
            int howMany = 0;
                        

            List<string> theList = new List<string>();

            Console.WriteLine("List Capacity : {0}", theList.Capacity);

            do
            {
                Console.WriteLine("\nPlease enter a word to add to a list. Place a '+' to add to the list and '-' to remove from the list");
                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav) 
                {
                    case '+': theList.Add(value); howMany++; break;

                    case '-': theList.Remove(value); howMany--; break;

                    default: Console.WriteLine("Ended up here because I haven't written code to validate the input"); break;
                }

                Console.WriteLine("\nNames in the List : " + howMany);
                Console.WriteLine("List Capacity is now : {0}", theList.Capacity, "\n");

                Console.WriteLine("Another Name 'y' or 'n'?");
                char again = Console.ReadKey().KeyChar;

                if (again == 'Y' || again == 'y')
                {
                    continue;
                }
                else { 
                
                EnteringData = false;
                
                }


            }
            while (EnteringData);
         
        }

        /// <summary>
        /// Examines the data-structure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method until the user inputs something to exit to main menu.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueuing and Dequeuing to see how it behaves
            */

            var EnteringData = true;
            Queue<string> ICAQueue = new Queue<string>();
            Console.WriteLine("\nTo start add someone to the queue type '+' in front of their name. To expedite type '-' in front of the name");
            Console.WriteLine("\nStart (Y/N)");
            char start = Console.ReadKey().KeyChar;

            if (start == 'Y' || start == 'y')

            {
                Console.WriteLine("\nThe checkout at ICA is now open");

                do
                {
                    Console.WriteLine("\nThe checkout now has : {0} people", ICAQueue.Count);
                    Console.Write("\nEnter Name: ");

                    string input = Console.ReadLine()!;
                    char nav = input[0];
                    string value = input.Substring(1);

                    switch (nav)
                    {
                        case '+': ICAQueue.Enqueue(value); Console.WriteLine($"\n{value} joined the queue"); break;

                        case '-': ICAQueue.Dequeue(); Console.WriteLine($"\n{value} has been expedited and left the queue"); break;

                        default: Console.WriteLine("Ended up here because I haven't written code to validate the input"); break;
                    }

                }
                while (EnteringData);
            }
            else
            {

                EnteringData = false;
                Console.WriteLine("\nThe checkout at ICA is closed");
                
            }
        }






 

        /// <summary>
        /// Examines the data structure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menu.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and popping to see how it behaves
            */

            var EnteringData = true;
            Stack<string> ICAStack = new Stack<string>();
            Console.WriteLine("\nTo start add someone to the queue type '+' in front of their name. To expedite type '-' in front of the name");
            Console.WriteLine("\nStart (Y/N)");
            char start = Console.ReadKey().KeyChar;

            if (start == 'Y' || start == 'y')

            {
                Console.WriteLine("\nThe checkout at ICA is now open");

                do
                {
                    Console.WriteLine("\nThe checkout now has : {0} people", ICAStack.Count);
                    Console.Write("\nEnter Name: ");

                    string input = Console.ReadLine()!;
                    char nav = input[0];
                    string value = input.Substring(1);
                    ReverseText(value); //Call to reverse text method that uses the Stack.

                    switch (nav)
                    {
                        case '+': ICAStack.Push(value); Console.WriteLine("\n{0} joined the queue", value); break;

                        case '-': ICAStack.Pop(); Console.WriteLine("\n{0} has been expedited and left the queue", value); break;

                        default: Console.WriteLine("Ended up here because I haven't written code to validate the input"); break;
                    }

                }
                while (EnteringData);
            }
            else
            {

                EnteringData = false;
                Console.WriteLine("\nThe checkout at ICA is closed");

            }
        }



        static void ReverseText(string text)
        {
            char[]charText = text.ToCharArray();    
            Stack<char> CharStack = new Stack<char>();
            for (int i = 0; i < charText.Length; i++) 
            { 
            CharStack.Push(charText[i]);
            }

            for (int r = 0; r < charText.Length; r++)
            {
                charText[r] = CharStack.Pop();
            }


            Console.Write("Entered name reversed: ");
            for (int p = 0; p < charText.Length; p++)
            {
                Console.Write(charText[p]);
            }
            

        }



























        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

