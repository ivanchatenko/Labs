using System;


namespace epam_2_1
{
    class Task1_2_epam
    {
        //Generating  aa matrix with random size[range:3-10]
        public static int[,] GenerateMatrix()
        {
            // creating a matrix with random sizes
            var rand = new Random();
            int a = rand.Next(7) + 3;
            int[,] matr = new int[a, a];

            //filling the matrix
            for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                    matr[i, j] = rand.Next(10);
            
            return matr;
        }
        
        public static void ShowMatrix(int[,] matr)
        {
            int length = matr.GetUpperBound(0) + 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                    Console.Write(matr[i,j] + " ");
                Console.WriteLine();
            }
        }

        //Inserting 0's and 1's under and over the main diagonal
        public static int[,] ChangeMatrix(int[,] matr)
        {
            int length = matr.GetUpperBound(0) + 1;
            
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    if(i < j)           matr[i, j] = 1;
                    else if (i > j)     matr[i, j] = 0;       
                }

            return matr;
        }
        static void Main(string[] args)
        {
            var mat = GenerateMatrix();
            Console.WriteLine("Generated Matrix : \n");
            ShowMatrix(mat);
            ChangeMatrix(mat);
            Console.WriteLine("Changed Matrix : \n");
            ShowMatrix(mat);
            Console.ReadKey();
        }
    }
}
