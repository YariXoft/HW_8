using System;


namespace HW_8
{
    struct Vector3D
    {
        public double X;
        public double Y;
        public double Z;
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D Mult(double digit) // вектор * число
        {
            return new Vector3D(X * digit, Y * digit, Z * digit);
        }
        public Vector3D Add(Vector3D v2) //вектор + вектор
        {
            return new Vector3D(X + v2.X, Y + v2.Y, Z + v2.Z);
        }
        public Vector3D Minus(Vector3D v2) // v - v
        {
            return new Vector3D(X - v2.X, Y - v2.Y, Z - v2.Z);
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
    // 2
    struct DecNumber
    {
        public int Value;
        public DecNumber(int value)
        {
            Value = value;
        }
        public string ToBin()
        {
            return Convert.ToString(Value, 2);
        }
        public string ToOct()
        {
            return Convert.ToString(Value, 8);
        }
        public string ToHex()
        {
            return Convert.ToString(Value, 16);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // 1 
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            Vector3D multVector = vector1.Mult(2);
            Console.WriteLine($"//1\n\nВектор * число: {multVector}");

            Vector3D sumVector = vector1.Add(vector2);
            Console.WriteLine($"Сума векторов: {sumVector}");

            Vector3D subVector = vector1.Minus(vector2);
            Console.WriteLine($"Рiзниця векторiв: {subVector}");

            // 2
            Console.WriteLine($"//2\n\n10-ве представлення: 123");

            DecNumber number = new DecNumber(123);
            string binary = number.ToBin();// 10 to 2 
            Console.WriteLine($"2-ве представлення: {binary}");

            string octal = number.ToOct(); // 10 to 8
            Console.WriteLine($"8-ве представлення: {octal}");

            string hexadecimal = number.ToHex();//10 to 16
            Console.WriteLine($"16-ве представлення: {hexadecimal}\n");
        }
    }
}
