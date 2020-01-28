using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Point:Lines
    {
        
        int X, Y;
        char SYM;

        public Point(int x,int y , char symb)
        {
            X = x;
            Y = y;
            SYM = symb;
            Draw(X, Y, SYM);
        }
        public Point()
        {

        }
      
        public Point next(Point a,direction dir)
        {
            if(dir == direction.DOWN)
            {
                a.Y += 1;
            }
            if (dir == direction.UP){
                a.Y -= 1;
                
            }
            if (dir == direction.LEFT)
            {
                a.X -= 1;
            }
            if (dir == direction.REIGTH)
            {
                a.X += 1;
            }
            Draw(a.X, a.Y, a.SYM);
            return a;
        }
        
        public Point check_point(List<Point> mon , List<Point> hh)
        {
            foreach (Point a in hh)
            {
                foreach (Point b in mon)
                {
                    if ((a.X == b.X + 2 || a.X == b.X - 2||a.X==b.X) && ((a.Y == b.Y+2||a.Y==b.Y-2||a.Y==b.Y)))
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        public bool checking(List<Point> mon,List<Point> hh)
        {
           foreach(Point a in hh)
            {
                foreach(Point b in mon)
                {
                    if ((a.X == b.X + 2 || a.X == b.X - 2 || a.X == b.X) && ((a.Y == b.Y + 2 || a.Y == b.Y - 2 || a.Y == b.Y)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public int get_x()
        {
            return X; 
        }
        
        
        public void clean(Point a)
        {
            Draw(a.X, a.Y, ' ');
        }
         void Draw (int x ,int y , char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
