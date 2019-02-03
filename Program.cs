using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_2Numbers_of_more_than_20_Characteres_each
{
    class Program
{
    static void Main(string[] args)
    {
        Program.myown_v2();
    }

    public static void myown_v1()
    {
        string a = "123456789123456789123456789123456789123456789";
        string b = "987654321987654321987654321987654321987654321";

        Console.WriteLine("Length of first value - {0}", a.Length);
        Console.WriteLine("Length of second value - {0}", b.Length);

        Console.Write("{0} + {1} = ", a, b);
        int max = 0;
        int rav;
        int carry = 0;
        string sum = "";

        if (a.Length >= b.Length)
        {
            max = a.Length;
            for (int i = 0; i < a.Length - 1; i++)
            {
                b = "0" + b;
            }
        }
        else
        {
            max = b.Length;
            for (int i = 0; i < b.Length - 1; i++)
            {
                a = "0" + a;
            }
        }
        char[] Rev1 = a.ToCharArray();
        char[] Rev2 = b.ToCharArray();
        Array.Reverse(Rev1);
        Array.Reverse(Rev2);

        string k = new string(Rev1);
        string l = new string(Rev2);

        string ravstr;
        for (int i = 0; i < max; i++)
        {
            rav = int.Parse(k[i].ToString()) + int.Parse(l[i].ToString()) + carry;
            carry = 0;

            if (rav.ToString().Length > 1 && rav.ToString().Length <= max)
            {
                ravstr = Convert.ToString(rav);
                for (int loc = 0; loc < ravstr.Length; loc++)
                {
                    if (loc == 1)
                    {
                        sum += ravstr[loc].ToString();
                    }
                    else
                    {
                        carry = int.Parse(ravstr[loc].ToString());
                    }
                }
            }
            else
            {
                sum += rav;
            }
        }
        if (carry != 0)
        {
            sum += carry;
        }
        char[] rev = sum.ToCharArray();
        Array.Reverse(rev);
        string final = new string(rev);
        Console.WriteLine(final);
    }

    public static void myown_v2()
    {
        string a, b;
        a = "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999";
        b = "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999";

        Console.WriteLine("Length of first value - {0}", a.Length);
        Console.WriteLine("Length of second value - {0}", b.Length);
        Console.Write("{0} + {1} = ", a, b);

        int rav, max = 0, carry = 0;
        string ravstr, sum = "";

        if (a.Length >= b.Length)
        {
            max = a.Length;
        }
        else
        {
            max = b.Length;
            for (int i = 0; i < b.Length - 1; i++)
            {
                a = "0" + a;
            }
        }

        for (int i = max - 1; i >= 0; i--)
        {
            rav = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString()) + carry;
            carry = 0;

            if (rav.ToString().Length > 1 && rav.ToString().Length <= max)
            {
                ravstr = Convert.ToString(rav);
                sum = ravstr[1].ToString() + sum;
                carry = int.Parse(ravstr[0].ToString());
            }
            else
            {
                sum = rav + sum;
            }
        }
        sum = carry != 0 ? carry + sum : sum;

        Console.WriteLine(sum);
    }

    public static void myown_v3()
    {
        //string a = "123456789123456789123456789123456789123456789";
        //string b = "987654321987654321987654321987654321987654321";
        string a = "", b = "", ravstr, sum = "";
        Console.WriteLine("Enter the First Value");
        a = Console.ReadLine();
        Console.WriteLine("Enter the Second Value");
        b = Console.ReadLine();
        int rav, min = a.Length, carry = 0, val;
        string sub = "0", firstString = String.Copy(a), secondString = String.Copy(b);

        Console.WriteLine("Length of first value - {0}", a.Length);
        Console.WriteLine("Length of second value - {0}", b.Length);
        Console.Write("{0} + {1} = ", a, b);

        if (a.Length > b.Length)
        {
            min = b.Length;
            sub = a.Substring(0, min - 1);
            firstString = String.Copy(b);
            secondString = String.Copy(a.Substring(min - 1));
        }
        else if (a.Length < b.Length)
        {
            min = a.Length;
            sub = b.Substring(0, min - 1);
            firstString = String.Copy(a);
            secondString = String.Copy(b.Substring(min - 1));
        }

        for (int i = min - 1; i >= 0; i--)
        {
            rav = int.Parse(firstString[i].ToString()) + int.Parse(secondString[i].ToString()) + carry;
            carry = 0;

            if (rav.ToString().Length > 1 && rav.ToString().Length <= min)
            {
                ravstr = Convert.ToString(rav);
                sum = ravstr[1].ToString() + sum;
                carry = int.Parse(ravstr[0].ToString());
            }
            else
            {
                sum = rav + sum;
            }
        }

        val = int.Parse(sub) + carry;
        sum = val == 0 ? sum : val + sum;
        Console.WriteLine(sum);
    }
}
}
