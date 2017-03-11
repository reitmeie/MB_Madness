using System;

namespace Programming
{
    ///------------------------------------------------------------------------
    /// <summary>
    /// Main program for performing math operations.  
    /// 
    /// You must enhance the program to perform:
    ///         Addition
    ///         Subtract
    ///         Multiply
    ///         Divide
    /// </summary>
    public class Math
    {
        ///--------------------------------------------------------------------
        /// <summary>
        /// This is the Entry point for program.  Its argument is an array of 
        /// each item in the command line.  Items in the command line are 
        /// separated by spaces.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // need to have an object to work with
            Math p = new Math();

            #region Process Command Line
            // make sure we have only 2 arguments - 2 numbers
            if (args.Length != 2)
            {
                // if there are any problems, print a usage message, and exit the program
                p.Usage();
                return;
            }

            // get the first number, and make sure it's a integer
            int a = 0;
            if (!int.TryParse(args[0], out a))
            {
                p.Usage();
                return;
            }

            // get the second number, and make sure it's an integer
            int b = 0;
            if (!int.TryParse(args[1], out b))
            {
                p.Usage();
                return;
            }
            #endregion

            // do math operations
int sum = Add(a, b);
int diff = Subtract(a, b);
            // print out the results
Console.WriteLine("{0} + {1} = {2}", a, b, sum);
Console.WriteLine("{0} - {1} = {2}",a, b, difference);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// This gets called whenever a Math object is created.  It will clear
        /// the screen.
        /// </summary>
        public Math()
        {
            Console.Clear();
        }

        ///--------------------------------------------------------------------
        /// <summary>
        /// This method contains our usage statement.  It will print out to 
        /// the console how the user can use the program.  \t indicates a
        /// special character should be used, in this case a "tab", which
        /// will indent the output line.
        /// </summary>
        private void Usage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("\tProgramming <int1> <int2>");
            Console.WriteLine("Where:");
            Console.WriteLine("\tint1: First integer");
            Console.WriteLine("\tint2: Second integer");
        }

	private int Add(int a, int b)
	{
		return a + b;
	}

	private int Subtract(int a, int b)
	{
		return a - b;
	}
    }

}
