using System;

namespace SCAC
{
    public class Program
    {

        const float numberOfFactors = 2;    //total number of factors
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
            public float multiplier       // can be calculated on basis of number of factors
            {
                get;
                set;
            }
            public string name    //name of the factor
            {
                get;
                set;
            }
        
            public factor( string n, int r =0, float m = 1 / numberOfFactors)
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
            factor[] arr = new factor[(int)numberOfFactors];                                             // fill attributes here   and update numberOFFactors
            arr[0] = new factor("fad");
            arr[1] = new factor("ass");

            foreach(factor a in arr)            //for test right now
            {
                Console.WriteLine(a.name+" "+a._rating+" "+a.multiplier);
            }

            for(int i =0; i<numberOfFactors;i++)
            {
                Console.WriteLine("enter score for "+ arr[i].name+"(Out of 10): ");
                arr[i].rating = Convert.ToInt16(Console.ReadLine());
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
