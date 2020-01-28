using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class My_Tank
    {
        int x, y;
        char sym;
        Point buffer = new Point();
        List<Point> my_tank_fire_list = new List<Point>();
        void my_tank_move(List<Point> tank_list , direction dir,List<Point> lines)
        {
            
            
                for (int i = 0; i < tank_list.Count; i++)
                {
                    buffer = tank_list[i];
                    buffer.clean(tank_list[i]);
                    tank_list[i] = buffer.next(tank_list[i], dir);
                }
            
        }
        List<Point> Tank = new List<Point>(); 
        public My_Tank(int x, int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            Point a = new Point(x, y, sym);
            Tank.Add(a);
            Point a1 = new Point(x-1, y+1, sym);
            Tank.Add(a1);
            Point a2 = new Point(x+1, y+1, sym);
            Tank.Add(a2);
        }
        public List<Point> get_tank_list()
        {
            return Tank;
        }
        void fire(List<Point> horizontal)
        {

            Point buffer = new Point();
            
            for ( int i = 0; i < my_tank_fire_list.Count; i++)
            {
                buffer = my_tank_fire_list[i];
                buffer.clean(my_tank_fire_list[i]);
                my_tank_fire_list[i] = buffer.next(my_tank_fire_list[i], direction.UP);
                if (check_lines(horizontal)) ;

            }
        }
        void fire_add()
        {
            Point fire_1 = new Point(Tank.First().get_x(), 27, '@');
            my_tank_fire_list.Add(fire_1);

        }
       public bool check_lines(List<Point> horizontal)
        {
            Point a = new Point();
            if (a.checking(my_tank_fire_list, horizontal))
            {
                a.clean(a.check_point(my_tank_fire_list, horizontal));
                my_tank_fire_list.Remove(a.check_point(my_tank_fire_list, horizontal));
                return true;
            }
            else return false;
        }
        public void My_Tank_move(List<Point> lines,List<Point> horizontal)
        {
            fire(horizontal);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.RightArrow)
                {
                    if (buffer.checking(Tank, lines))
                    {
                        return;
                    }
                    else
                    {
                        my_tank_move(Tank, direction.REIGTH, lines);

                    }

                    
                }
                if(key.Key == ConsoleKey.Spacebar)
                {

                    fire_add();
                    
                }
                if(key.Key == ConsoleKey.LeftArrow)
                {
                    if (buffer.checking(Tank, lines))
                    {
                        return;

                        

                    }
                    else
                    {

                          my_tank_move(Tank, direction.LEFT,lines);
                    }
                   
                }
            }
        }
    }
}
