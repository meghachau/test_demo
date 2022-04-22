using System;


namespace Inheritance_and_Polymorphism
{
    public class StackException : Exception
    {
        public StackException(String message) : base(message)
        {
            // Calls Exception's constructor    
        }
    }

    public interface StackADT
    {
        //Boolean isEmpty();
        void Push(int element);
        int Pop();

    }
    public class stack : StackADT
    {
        public static int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }
        public int top;
        int[] item;
        public stack()
        {
            StackSizeSet = 3;
            item = new int[StackSizeSet];
            top = -1;
        }
        
        public void Push(int element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
                Console.WriteLine("Item pushed successfully..");
            }
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return Convert.ToInt32("No elements");
            }
            else
            {

                return item[top--];
            }
        }


        public class stackException
        {
            public int StackSize;
            public static void Main()
            {

                stack st = new stack();
                while (true)
                {
                    Console.WriteLine("\nStack MENU(size --> 5)");
                    Console.WriteLine("1. Add an element");
                    Console.WriteLine("2. Remove top element.");
                   
                    Console.WriteLine("3. Exit");
                    Console.Write("Select your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //for (int i = 0; i < st.StackSizeSet; i++)
                            //{
                                Console.WriteLine("Enter an Element : ");
                                st.Push(Convert.ToInt32(Console.ReadLine()));
                           // }

                            try
                            {
                                if (st.top == (st.StackSizeSet - 1))
                                {
                                    throw new StackException("Stack is overflow....");

                                }
                            }
                            catch (StackException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Top element is: {0}", st.Pop());
                            try
                            {
                                if (st.top == -1)
                                {
                                    throw new StackException("Stack is underflow....");
                                }
                            }
                            catch(StackException e) 
                            {
                                Console.WriteLine(e.Message);
                            }
                                break;
                        case 3:
                            System.Environment.Exit(1);
                            break;

                    }
                    Console.ReadKey();
                }


            }


        }

    }
}
