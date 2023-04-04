// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Text;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        String stuNum;
        int mark1;
        int mark2;
        int add;
        double aver;
        String pass;
        String fail;
        String distinction;

        String[,] studentInfo = new String[10,6];

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter a student number:");
            stuNum = Console.ReadLine();
            studentInfo[i, 0] = stuNum;

            Console.WriteLine("Enter your first mark: ");
            mark1 = Convert.ToInt32(Console.ReadLine());
            studentInfo[i, 1] = Convert.ToString(mark1);

            Console.WriteLine("Enter your second mark: ");
            mark2 = Convert.ToInt32(Console.ReadLine());
            studentInfo[i, 2] = Convert.ToString(mark2);

            add = sum(mark1, mark2);
            studentInfo[i, 3] = Convert.ToString(add);

            aver = ave(mark1, mark2);
            studentInfo[i, 4] = Convert.ToString(aver);

            if(aver < 50)
            {
                fail = "Fail";
                studentInfo[i, 5] = fail;
            }
            if(aver >= 50)
            {
                pass = "Pass";
                studentInfo[i, 5] = pass;
            }
            if (aver >= 75)
            {
                distinction = "Distinction";
                studentInfo[i, 5] = distinction;
            }

        }

        Console.WriteLine("Student Number: Mark 1: Mark 2: Total:  Average:  Results:");
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                Console.Write(studentInfo[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }

    public static int sum(int mk1, int mk2)
    {
        int sumTotal = mk1 + mk2;
        return sumTotal;
    }

    public static double ave(int mk1, int mk2)
    {
        double aveTotal = (mk1 + mk2)/2;
        return aveTotal;
    }
}
