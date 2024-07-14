using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    public class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i+1);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            for(int i = m; i <= n; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Returns the tenth even number, with 2 as the first even number
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {   
            int evenQty = 0;
            int num = 0;
            while (evenQty != 10)
            {
                num++;
                if (num % 2 == 0)
                {
                    evenQty++;
                }
            }
            return num;
        }

        /// <summary>
        /// Returns the nth even number, with 2 as the first even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            int evenQty = 0;
            int num = 0;
            while (evenQty != n) 
            {
                num++;
                if(num % 2 == 0)
                {
                    evenQty++;
                }
            }
            return num;
        }

        #endregion
    }
}