/* Luke Duell
 * Instructor: Professor Hanoudi
 * CSCI 234: Object Oriented Programming w/C#
 * Assignment 20.10
 * Description: This program uses a class to 
 *              call a function to see if a
 *              and b match. If they do the
 *              console prompts the user that they
 *              match and if not it prompts the user
 *              that it does not match.
 */

using System;
class IsEqual_To
{
    public bool IsEqualTo(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

class WritetoConsole
{
    static void Main()
    {
        int a = 0, b = 0;
        IsEqual_To equalcheck = new IsEqual_To();

        //first instand where a does equal b

        a = 9;
        b = 100;

        //calling the funciton to see if a and b match
        if (equalcheck.IsEqualTo(a, b))
        {
            Console.WriteLine($"{a} and {b} match");
        }
        else
        {
            Console.WriteLine($"{a} and {b} do not match");
        }

        a = 100;
        b = 100;

        //calling the funciton to see if a and b match
        if (equalcheck.IsEqualTo(a, b))
        {
            Console.WriteLine($"{a} and {b} match");
        }
        else
        {
            Console.WriteLine($"{a} and {b} do not match");
        }
    }
}

