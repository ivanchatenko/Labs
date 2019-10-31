using System;


namespace Epam_5_1
{
    
    class User
        {
        private static int lowerBound;
        private int upperBound;
        private static User[] users = new User[100];
        public int UpperBound
        {
            get { return upperBound; }
            set { upperBound = value; }
        }
        public static int LowerBound
        {
            get { return lowerBound; } 
            set { lowerBound = value; }
        }
        public User()
        {
            Random random = new Random();
            lowerBound = random.Next(1, 50);
            upperBound = lowerBound + random.Next(1, 50);
        }
        public User(string name)
        {
            Name = name;
        }
        public User this[int i]
        {
            get => users[i + lowerBound];
            set => users[i + lowerBound] = value;
        }
        public string Name { get; set; }    
        public int Length
        {
            get
            {
                int a = 0;
                foreach (User item in users)
                   if(item != null) a++;
                return a;
            }
        } 
    }
    class Program
    {
        public static void ShowUsers(User person)
        {
            var i = User.LowerBound;
            var j = person.UpperBound;
            for (; i < j; i++)
            {
                Console.WriteLine(person[i].Name);
            }
        }
        public static void GenerateUsers(User person)
        {
            var i = User.LowerBound;
            var j = person.UpperBound;
            for (; i < j; i++)
            {
                person[i] = new User("Bill");
            }
        }
        static void Main(string[] args)
        {
            //User person = new User();
            //GenerateUsers(person);
            //Console.WriteLine("Lower bound: " + User.LowerBound);
            //Console.WriteLine("Upper bound: " + person.UpperBound);
            //Console.WriteLine("Length: " + person.Length);
            //ShowUsers(person);


            //Polynomical pol1 = new Polynomical(5,2);
            //Polynomical pol2 = new Polynomical(1, 2, 3, 4);
            //Console.WriteLine(pol1.ToString());
            //Console.WriteLine(pol2.ToString());
            //Console.WriteLine(pol1+pol2);
            //Console.WriteLine(pol1 - pol2);
            //Console.WriteLine(pol1 * pol2);
            PolynomicalDictionary polDict1 = new PolynomicalDictionary();
            polDict1[0] = 8;
            polDict1[1] = 7;
            polDict1[2] = 6;
            polDict1[3] = 5;
            PolynomicalDictionary polDict2 = new PolynomicalDictionary();
            polDict2[2] = 8;
            polDict2[3] = 7;
            PolynomicalDictionary polDict3 = new PolynomicalDictionary();
            polDict3 = null;
            // 8 + 7x + 6x^2 + 5x^3
            // 8x^2 + 7x^3+
            // a*b = 64x^2 + 56x^3 + 56x^3 + 48x^4 + 48x^4 + 
            Console.WriteLine(polDict1.ToString());
            Console.WriteLine(polDict2.ToString());
            Console.WriteLine(polDict1 + polDict3);
            //Console.WriteLine(polDict1 - polDict2);
            Console.WriteLine("\n" + polDict1 * polDict2);

            Console.ReadKey();
        }

    }
}
