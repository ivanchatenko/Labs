using System;


namespace Epam_5_1
{
    
    class User
        {
        private static int lowerBound;
        private int upperBound;

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
        // Declare an array to store the data elements.
        private static User[] users = new User[100];

        // Define the indexer to allow client code to use [] notation.
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
            User person = new User();
            GenerateUsers(person);  
            Console.WriteLine("Lower bound: " + User.LowerBound);
            Console.WriteLine("Upper bound: " + person.UpperBound);
            Console.WriteLine("Length: " + person.Length);
            ShowUsers(person);
            Console.ReadKey();
        }

    }
}
