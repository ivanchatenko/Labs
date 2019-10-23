using System;


namespace Epam_4_1
{
    class ArithmethicProgression
    {
        public ArithmethicProgression(int firstValue,int diffValue,int stepValue)
        {
            FirstValue = firstValue;
            DiffValue = diffValue;
            StepValue = stepValue;
            EndValue = firstValue + (stepValue - 1) * diffValue;
        }
        // AP = firstValue + (stepValue - 1)*diffValue
        private int firstValue;
        private int diffValue;
        private int stepValue;
        private int endValue;

        public int FirstValue
        {
            get { return firstValue; }
            set { firstValue = value; }
        }
        public int EndValue
        {
            get { return endValue; }
            set { endValue = value; }
        }
        public int DiffValue
        {
            get { return diffValue; }
            set { diffValue = value; }
        }
        public int StepValue
        {
            get { return stepValue; }
            set { stepValue = value; }
        }
        public double AverageArith() =>   (ArithemthicSum() / stepValue);
        public double ArithemthicSum() => (firstValue + endValue) / 2 * stepValue;
    }
    class Rectangle
    {
        public Rectangle(int side)
        {
            Side = side;
        }
        private int Side;
        public int MyProperty
        {
            get { return Side; }
            set { if(value > 0 ) Side = value; }
        }

        public int GetPerimeter() =>  Side * 4;
        public int GetArea() => Side * Side;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5);
            Console.WriteLine(r1.GetArea());
            ArithmethicProgression a1 = new ArithmethicProgression(10,2,7);
            Console.WriteLine(a1.ArithemthicSum());
            Console.WriteLine(a1.AverageArith());
            Console.ReadKey();
        }
    }
}
