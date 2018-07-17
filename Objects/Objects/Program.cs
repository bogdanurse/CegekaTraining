using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double pointx, double pointy)
        {
            X = pointx;
            Y = pointy;
        }
        public Point()
        {

        }
        public double DistanceTo(Point otherpoint)
        {
            return Math.Sqrt((this.X - otherpoint.X) * (this.X - otherpoint.X) + (this.Y - otherpoint.Y) * (this.Y - otherpoint.Y));
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool IsPointInCircle(Point point)
        {
            return (point.DistanceTo(this.Center) <= this.Radius);
        }

        public bool CollidesWith(Circle other)
        {
            return (this.Center.DistanceTo(other.Center) < (this.Radius + other.Radius));
        }

        public bool Contains(Circle other)
        {
            double distanceBetweenCenters = this.Center.DistanceTo(other.Center);
            return distanceBetweenCenters < this.Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point circleCenter = ReadPoint("Enter center coordinates");

            Console.WriteLine("Enter a radius for the first circle: ");
            double circleRadius = double.Parse(Console.ReadLine());

            Point clickPoint = ReadPoint("Enter click coordinates");

            Point othercircleCenter = ReadPoint("Enter second circle coordinates");

            Console.WriteLine("Enter a radius for the second circle: ");
            double othercircleRadius = double.Parse(Console.ReadLine());


            Circle cerc = new Circle
            {
                Center = circleCenter,
                Radius = circleRadius
            };

            Circle otherCircle = new Circle
            {
                Center = othercircleCenter,
                Radius = othercircleRadius
            };

            Console.WriteLine("It's the circles collides? {0}", (cerc.CollidesWith(otherCircle)));

            Console.WriteLine("It's in the circle? {0}", (cerc.IsPointInCircle(clickPoint)));
            */

            var circle = ReadCircle("Describe a circle : ");

            var otherCircle = ReadCircle("Describe second circle : ");
        }

        static Point ReadPoint(string promt)
        {
            Point punct = new Point();
            Console.WriteLine("{0} X  : ", promt);
            punct.X = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} Y  : ", promt);
            punct.Y = double.Parse(Console.ReadLine());

            return punct;
        }

        static Circle ReadCircle(string promt)
        {
            Circle cerc = new Circle();

            Console.WriteLine("{0} :", promt);

            cerc.Center = ReadPoint("Introduce circle data: ");

            Console.WriteLine("Create data for the first circle about radius:");
            cerc.Radius = double.Parse(Console.ReadLine());

            return cerc;

        }
    }
}
