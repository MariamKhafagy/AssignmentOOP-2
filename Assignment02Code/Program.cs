namespace Assignment02Code
{
    internal class Program
    {
        
        static void Main(string[] args)

        {
            #region Part 1


            //Point3D P1 = new Point3D(10, 10, 10);
            //Console.WriteLine(P1);


            //Point3D P2 = new Point3D(10, 10, 10);    

            //if (P1==P2)
            //    Console.WriteLine("P1 And P2 Are Equal");
            //else 
            //    Console.WriteLine("P1 and P2 not Equal");

            //// 2lsort array

            //Point3D[] points =new Point3D[5];
            //{
            //    new Point3D(3, 5, 1);
            //    new Point3D(3, 5, 2);
            //    new Point3D(3, 5, 3);
            //    new Point3D(3, 5, 4);


            //};

            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point3D(0, 0, 0); 

            //}
            //foreach (var p in points)
            //{
            //    if (p != null)
            //    {
            //        Console.WriteLine(p);
            //    }
            //    else
            //        Console.WriteLine("null point found ");
            //}

            //Array.Sort(points);
            //Console.WriteLine("\n sorted Points");



            //Point3D cloned = (Point3D)P1.Clone();
            //Console.WriteLine($"\n Cloned P1 : {cloned}");



            //    int x = ReadInt("Enter X :");



            #endregion

            #region Part2
            //int x = 30 , y = 6 ; 

            //Console.WriteLine("Add : " + Maths.Add(x,y));
            //Console.WriteLine("Substract : " + Maths.Subtract(x,y));
            //Console.WriteLine("Multpily  : " + Maths.Multiply(x, y));
            //Console.WriteLine("Divied : " + Maths.Divide(x,y));

            #endregion

            #region Part 3 
            //Duration D1= new Duration(1,10,5);
            //Console.WriteLine(D1);

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2);

            //Duration D3 = new Duration(333);
            //Console.WriteLine(D3);

            //D3 = D1 + D2;
            //Console.WriteLine("D3 = D1 + D2 " +D3);

            //D3 = D1 + 7800;
            //Console.WriteLine("D3 = D1 =7800 "+D3);

            //D3 = 666 + D3;
            //Console.WriteLine("D3 = 666 + D3 ");

            //D3 = ++D1;
            //Console.WriteLine("D3=++D1" +D3);

            //D3 = --D1;
            //Console.WriteLine("D3=--D1"+D3 );

            //D1 = D1 - D2;
            //Console.WriteLine("D1 = D1 - D2" +D1);

            //if (D1 > D2)
            //    Console.WriteLine("D1 is greater than D2");

            //if (D1 <= D2)
            //    Console.WriteLine("D1 is less thsn of Equal ");

            //if (D1)
            //    Console.WriteLine("D1 has A Value");

            //TimeSpan span = (TimeSpan)D1;
            //Console.WriteLine(span);
            #endregion

        }

        #region Part1 
        //static int ReadInt(string prompt)
        //{
        //    int value;
        //    while (true)
        //    {
        //        Console.WriteLine(prompt);
        //        string input = Console.ReadLine()!;

        //        if (int.TryParse(input, out value))
        //            return value;
        //        else
        //            Console.WriteLine("Invalid input.Please enter a valid number .");

        //    }
        //}

        #endregion
    }
}
