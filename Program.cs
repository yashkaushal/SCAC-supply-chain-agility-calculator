using System;

namespace SCAC
{
    public class Program
    {

        const float numberOfFactors = 15;    //total number of factors
        struct factor
        {
            public  int _rating;
            public int rating  //from 0 to 10, 0 meaning not applicable
            {
                get
                {
                    return this._rating;
                }
                set
                {
                    if (value <= 10 && value >= 0)
                    {
                        _rating = value;
                    }
                    else
                    {
                        int a;      //temp rating checking var
                        do
                        {
                            Console.WriteLine("rating must be between 0-10");
                            Console.Write("enter rating: ");

                            a = System.Convert.ToInt16(Console.ReadLine());
                            a = this._rating;
                        } while (a > 10 || a < 0);
                    }
                }


            }
            public double multiplier       // can be calculated on basis of number of factors
            {
                get;
                set;
            }
            public string name    //name of the factor
            {
                get;
                set;
            }
        
            public factor( string n, int r =0, double m = 1 / numberOfFactors)
            {
                this.name = n;
                this.multiplier = m;
                _rating =r;
                while(_rating > 10 || _rating < 0)
                {
                    Console.WriteLine("rating must be between 0-10");
                    Console.Write("enter rating: ");

                    r = System.Convert.ToInt16(Console.ReadLine());
                    this._rating = r;
                }

            }

        }
        public static void Main(string[] args)
        {
/*TEST STUFF        Console.WriteLine("Hello World!");
            factor speed = new factor();;
            speed.rating = 3;
            speed.name = "fad";
            speed.multiplier =1;
            Console.Write(nameof(factor)+" "+speed._rating+" "+speed.multiplier);
TEST STUFF*/

            int factornumber = -1;
            factor[] arr = new factor[(int)numberOfFactors];                                             // fill attributes here   and update numberOFFactors
            arr[++factornumber] = new factor("My company is quick to detect changes in its environment.", m:0.1940657578);
            arr[++factornumber] = new factor("My company is quick to detect opportunities in its environment.",m:0.1940657578);
            arr[++factornumber] = new factor("My company is quick to detect threats in its environment.",m:0.1940657578);
            arr[++factornumber] = new factor("Our suppliers are quick to share relevant information with us.",m:0.1828388132);
            arr[++factornumber] = new factor("Our customers are quick to share relevant information with us.",m:0.1828388132);
            arr[++factornumber] = new factor("Usually, we can quickly access the data we need to make decisions.",m:0.1828388132);
            arr[++factornumber] = new factor("My company has processes in place that allow for quick decision making.",m:0.2173215718);
            arr[++factornumber] = new factor("My company is fast at making decisions regarding supply chain operations.",m:0.2173215718);
            arr[++factornumber] = new factor("My company is fast at making decisions regarding supply chain tactics.",m:0.2173215718);
            arr[++factornumber] = new factor("When it makes decisions regarding a change in its supply chain operations,my company can quickly implement it.",m:0.2068965517);
            arr[++factornumber] = new factor("When it makes decisions regarding a change in its supply chain tactics,my company can quickly implement it.",m:0.2068965517);
            arr[++factornumber] = new factor("my company is quick at implementing changes to its supply chain.",m:0.2068965517);
            arr[++factornumber] = new factor("My company's suppliers can quickly meet an increase in order size.",m:0.1988773055);
            arr[++factornumber] = new factor("My company's suppliers can quickly adjust the specification of orders.",m:0.1988773055);
            arr[++factornumber] = new factor("My company's suppliers can quickly adjust/expedite their delivery lead time.",m:0.1988773055);



  /*          foreach(factor a in arr)            //for test right now
            {
                Console.WriteLine(a.name+" "+a._rating+" "+a.multiplier);
            }
*/

            Console.Clear();
            Console.Title= ("Supply Chain Agility Calculator");
            Console.WriteLine("***SUPPLY CHAIN AGILITY CALCULATOR***\n");


            for(int i =0; i<numberOfFactors;i++)
            {
                Console.Write(arr[i].name+"(Out of 10): ");
                arr[i].rating = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");

            }

            decimal score =0;

            foreach(factor a in arr)
            {
                score += (decimal)(a._rating*a.multiplier);
            }
            Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Your Agility Score is "+score);
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}





/*

    create factors with scales(upto 10)
    create multipliers of factors
    sum of factors*multipliers should be equal to 1
    take input from user(rating)
    calculate score
    score is agility index 



*/
