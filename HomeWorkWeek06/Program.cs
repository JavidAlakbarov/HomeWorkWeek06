using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#region Task01
//internal class Task01
//{
//    static void Main(string[] args)
//    {
//        Thread thread = Thread.CurrentThread;
//        var secThread = new Thread(Method2);
//        secThread.Start();
//        Method1();        
//    }
//    static void Method1()
//    {
//        for (int i = 0; i < 100; i++)
//        {
//            Console.WriteLine("Method1 :" + i);
//            Thread.Sleep(200);
//        }
//    }
//    static void Method2()
//    {
//        for(int i=0; i < 100; i++)
//        {
//            Console.WriteLine("Method2 :" + i);
//            Thread.Sleep(200);
//        }
//    }
//}
#endregion Task01
#region Task02
//namespace HomeWorkWeek06
//{

//    internal class Program
//    {
//        static async Task Main(string[] args)
//        {
//            const string url = "https://catfact.ninja/fact";
//            HttpClient client = new HttpClient();
//            Console.WriteLine("Show me some facts");
//            do
//            {
//                var stringResult = await client.GetStringAsync(url);
//                Console.WriteLine(stringResult);
//            }
//            while (Convert.ToBoolean(Console.ReadLine()));
//        }
//    }
//}
#endregion Task02
#region Task03Version01
//internal class Task03
//{
//    static void Main(string[] args)
//    {
//        string task03;
//        Console.Write("Enter a string :");
//        task03 = Console.ReadLine();
//        int count,
//        sum = 0;
//        int sentence = task03.Length;
//        for (count = 0; count < sentence; count++)
//        {
//            if ((task03[count] >= '0') && (task03[count] <= '9'))
//            {
//                sum += (task03[count] - '0');
//            }
//        }
//        Console.WriteLine("Number of digits in string :" + count);
//    }
//}
#endregion Task03
#region Task03Version02
//class SumDigitsInStringTask
//{
//    static int SumDigitsInString(string str)
//    {
//        var sum = 0;
//        for (var i = 0; i < str.Length; i++)
//        {
//            if (char.IsDigit(str[i]))
//            {
//                sum += (int)char.GetNumericValue(str[i]);
//            }
//        }
//        return sum;
//    }
//    public static void Main()
//    {
//        Console.WriteLine(SumDigitsInString("1q2w3e"));
//        Console.WriteLine(SumDigitsInString("L0r3m.1p5um"));
//        Console.WriteLine(SumDigitsInString(""));
//    }
//}
#endregion Task03Version02   
#region Task05
//internal class Task05
//{
//    static void Main(string[] args)
//    {
//        string str;
//        Console.Write("Input the string : ");
//        str = Console.ReadLine();

//        var ucWord = WordFilt(str);
//        Console.WriteLine("The upper case words are :");
//        foreach (string strRet in ucWord)
//        {
//            Console.WriteLine(strRet);
//        }
//        Console.ReadLine();
//    }

//    static IEnumerable<string> WordFilt(string mystr)
//    {
//        var upWord = mystr.Split(' ')
//                    .Where(x => String.Equals(x, x.ToUpper(),
//                    StringComparison.Ordinal));

//        return upWord;
//    }
//}
#endregion Task05
#region Task06
//internal class YearLeap
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a year : ");
//        int year = int.Parse(Console.ReadLine());
//        if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
//        {
//            Console.WriteLine(year + " is a leap year");
//        }
//        else
//        {
//            Console.WriteLine(year + " is not a leap year");
//        }
//    }
//}
#endregion Task06


