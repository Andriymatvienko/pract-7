class Triangle
{
    private int[,] verticles;
    public Triangle(int[,] verticles)

    {
        if (verticles.GetLength(0) != 3)
        {
            throw new ArgumentException("Трикутник повинен мати три вершини");
        }
        this.verticles = verticles;

    }
    public int this[int i]
    {
        get
        {
            int j = (i + 1) % 3;//індекс наст.вершини

            return Math.Abs(verticles[i, 0] - verticles[j, 0] + Math.Abs(verticles[i, 1] - verticles[j, 1]));
        }
    }
    public void InputVerticles()
    {
        Console.WriteLine("Введіть координато вершин трикутника:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Вершина {0}:", i + 1);
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            verticles[i, 0] = x;
            verticles[i, 1] = y;
        }
    }
    public void OutputVerticles()
    {
        Console.WriteLine("Координати вершин трикутника:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Вершина {0}: ({1},{2})", i + 1, verticles[i, 0], verticles[i, 1]);

        }
    }
    public int Perimeter()
    {
        int perimeter = 0;
        for (int i = 0; i < 3; i++)
        {
            perimeter += this[i];
        }
        return perimeter;
    }
    public double Area()
    {
        double area = (verticles[0, 0] * (verticles[1, 1] - verticles[2, 1]) + verticles[1, 0] * (verticles[2, 1] - verticles[0, 1]) + verticles[2, 0] * (verticles[0, 1] - verticles[1, 1])) / 2;
        return Math.Abs(area);
    }
}
    class program
    {
        static void Main(string[] args)
        {
            int[,] verticles = new int[3, 2];
            Triangle triangle = new Triangle(verticles);

            triangle.InputVerticles();
            triangle.OutputVerticles();

            int side1 = triangle[0];
            int side2 = triangle[1];
            int side3 = triangle[2];

            Console.WriteLine("Сторона 1: {0}", side1);
            Console.WriteLine("Сторона 1: {0}", side2);
            Console.WriteLine("Сторона 1: {0}", side3);

            int perimeter = triangle.Perimeter();
            double area = triangle.Area();

            Console.WriteLine("Периметр:{0}", perimeter);
            Console.WriteLine("Площа: {0}", area);
        }
    }
