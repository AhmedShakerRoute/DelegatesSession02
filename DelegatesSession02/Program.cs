using DelegatesSession02.BasicDelegate;
using DelegatesSession02.BuiltInDelegate;
using DelegatesSession02.DelegateAsParameter;
using DelegatesSession02.MultiCastDelegate;
using DelegatesSession02.MultiCastReturnValue;
using static DelegatesSession02.BasicDelegate.Calculator;

namespace DelegatesSession02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Delegate [Calculator Example]
            //int a = 10;
            //int b = 20;
            ////int sum =   Calculator.Add(a , b);
            ////int Subtract =   Calculator.Subtract(a , b);


            //MathOperation Add = Calculator.Add;

            //Console.WriteLine($"Add(a,b) = {Add(a , b)}");

            //MathOperation Subtract = Calculator.Subtract;
            //Console.WriteLine($"Subtarct(a , b) = {Subtract(a,b)}");


            #endregion


            #region MyRegion



            //List<int> numbers = new List<int>() { 1, -2, 3, 4, 9, 8, 10, 11, 12 };
            //Helper.PrintList("Numbers", numbers);

            //List<int> Evens = NumberProcessor.Filter(numbers, NumberProcessor.IsEven);
            //List<int> Odd = NumberProcessor.Filter(numbers, NumberProcessor.IsOdd);
            //List<int> IsPositive = NumberProcessor.Filter(numbers, NumberProcessor.IsPositive);
            //List<int> GreaterThan10 = NumberProcessor.Filter(numbers, NumberProcessor.IsGreaterThan10);

            //Helper.PrintList("EvenNumbers", Evens);
            //Helper.PrintList("OddNumbers", Odd);
            //Helper.PrintList("PositiveNumbers", IsPositive);
            ////Helper.PrintList("GreaterThan10", GreaterThan10);

            //List<int> DoubledList = NumberProcessor.Transform(numbers, NumberProcessor.Double);
            //Helper.PrintList("DoubledList", DoubledList);



            #endregion


            #region MyRegion

            //NotifyDelegate notify = Notification.SendEmail;
            //notify += Notification.SendSMS;
            //notify += Notification.SendPush;
            //notify("Request Session");
            //Console.WriteLine("=============================================");
            ////Remove SMS From Chain
            //notify -= Notification.SendSMS;
            //notify += Notification.SendSMS;
            //notify("Request Session");







            #endregion
            #region MyRegion


            //ProcessDelegate process = Processor.AddTen;
            //process += Processor.MultiPlyByTwo;

            //int input = 5;
            ////int result = process(input);
            ////Console.WriteLine($"Result = {result}");



            //Delegate[] delegates = process.GetInvocationList();

            //Console.WriteLine($"Length of Methods {delegates.Length}");

            //foreach (ProcessDelegate delegator in delegates )
            //{
            //    int result = delegator(input);
            //    Console.WriteLine($"  Result = {result}");
            //}


            #endregion

            #region Action -- Void -- 0 => 16

            //Action greet = ActionExample.Greet;
            //greet();

            //Action<string> greet02 = ActionExample.GreetPerson;
            //greet02("Ahmed");

            //Action<string,int> greet03 = ActionExample.GreetPersonWithAge;
            //greet03("Ali", 20);






            #endregion

            #region Func 
            //doesnt has Void  
            //TResult
            //t1 , TResult
            //t1 , t2 , TResult



            //Func<int> getRandomNumber = FuncExample.GetRandomNumber;
            //Console.WriteLine($"Random Number = {getRandomNumber()}");


            //Func<int, int> square = FuncExample.Square;
            //Console.WriteLine($"Squared Number = {square(10)}");

            //Func<int , int , int> addFunc = FuncExample.Add;
            //Console.WriteLine(addFunc(10 , 20));

            Func<int , bool> IsEven = FuncExample.IsEven;
            //Console.WriteLine($"IsEven = {IsEven(10)}");



            #endregion

            #region Predicate


            //Predicate<int> ISPositive = PredicateExample.IsPositive;
            //Predicate<string> isLong = PredicateExample.IsLong;
            //Console.WriteLine(ISPositive(5));//True
            //Console.WriteLine(isLong("AhmedShaker"));//True

            ////List<int> list = [1, 2, 3, 4, 5];
            ////list.Where(ISPositive);

            //Console.WriteLine("Ahmed");
            //Action<string> print = Console.WriteLine;
            //print("Hello World");





            #endregion


            //Action<string> greet02 = ActionExample.GreetPerson;
            //
            //greet02 = delegate (string Name) {Console.WriteLine($"Hello {Name}");}; // Anonmous MEthod
            Action<string>  greet02 = name => Console.WriteLine($"Hello {name}"); // Lambda Expression
            greet02("Ahmed");


    }
    }
}
