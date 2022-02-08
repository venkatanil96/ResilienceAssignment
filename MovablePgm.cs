//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment
//{
//    interface IMovable
//    {
//        void MoveUp();
//        void MoveDown();
//        void MoveLeft();
//        void MoveRight();
//    }


//    class MovablePoint : IMovable
//    {

//        int x, y, xSpeed, ySpeed;


//        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
//        {
//            this.x = x;
//            this.y = y;
//            this.xSpeed = xSpeed;
//            this.ySpeed = ySpeed;
//        }

//        public String toString()
//        {
//            return "Point at (" + x + "," + y + ") XSPEED: " + xSpeed + " YSPEED: " + ySpeed;
//        }

//        public void MoveUp()
//        {
//            y -= ySpeed;
//        }

//        public void MoveDown()
//        {
//            y += ySpeed;

//        }

//        public void MoveLeft()
//        {
//            x -= xSpeed;
//        }

//        public void MoveRight()
//        {
//            x += xSpeed;
//        }


//        public int compareTo(MovablePoint point)
//        {
//            if (this.x == point.x)
//            {
//                return (int)(this.y - point.y);
//            }
//            else
//            {
//                return (int)(this.x - point.x);
//            }
//        }
//    }
//    class MovableCircle : IMovable
//    {
//        public MovablePoint center;
//        public int radius;


//        public int getRadius()
//        {
//            return radius;
//        }
//        public MovablePoint getCenter()
//        {
//            return center;
//        }

//        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius)
//        {
//            center = new MovablePoint(x, y, xSpeed, ySpeed);
//            this.radius = radius;
//        }

//        public void MoveUp()
//        {
//            center.y -= center.ySpeed;
//        }

//        public void MoveDown()
//        {
//            center.y += center.ySpeed;
//        }

//        public void MoveLeft()
//        {
//            center.x -= center.xSpeed;
//        }

//        public void MoveRight()
//        {
//            center.x += center.xSpeed;
//        }


//        public String ToString()
//        {
//            return "Center at (" + center.x + "," + center.y + ") XSPEED: " + center.xSpeed + " YSPEED: " + center.ySpeed + " RADIUS: " + this.radius;
//        }


//    }
//    class MovablePgm
//    {
//        static void Main(string[] args)
//        {
//            IMovable m1 = new MovablePoint(5, 6, 10, 20);
//            Console.WriteLine(m1);
//            m1.MoveLeft();

//            IMovable m2 = new MovableCircle(2, 1, 2, 20, 25);
//            Console.WriteLine(m2);

//            m2.MoveRight();
//        }

//    }
//}
