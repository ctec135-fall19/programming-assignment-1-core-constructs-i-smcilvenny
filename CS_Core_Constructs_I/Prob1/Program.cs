/*
Author: Sean McIlvenny
Date:   10/19/19
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example of a code region
            // some code
            #endregion
            //variable declaration
            double dbl;
            double dbl = 1.123;
            dbl2 = new double(1.122);
            #region another code region
            // some code
            #endregion

            #region
            //variable initialization
            bool t = true;
            byte myByte = 14;
            short myShort = 12200;
            int myInt = 99999;
            long myLong = 78944;
            float myFloat = 543.12;
            double myDbl = 12.00001;
            decimal myDec = 10.01010;

            Console.WriteLine("True or False: {0}",t);
            Console.WriteLine("byte: {0}", myByte);
            Console.WriteLine("short: {0}", myShort);
            Console.WriteLine("int: {0}", myInt);
            Console.WriteLine("long: {0}", myLong);
            Console.WriteLine("float to currency: {0:c}", myFloat);
            Console.WriteLine("double to decimal: {0:d}", myDbl);
            Console.WriteLine("decimal to fixed point: {0:2f}", myDec);
            #endregion

            #region
            //Max Min Values
            byte max = 255;
            byte min = 0;
            Console.WriteLine("The max value of a byte is: {0}", max);
            Console.WriteLine("The min value of a byte is: {0}", min);


            #endregion
        }
    }
}
