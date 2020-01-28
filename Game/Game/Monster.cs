using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        int x, y;
        public direction f ;
        char sym;
        List<Point> fire = new List<Point>();
        List<Point> monster_list = new List<Point>();
        public Monster(int x , int y , char sym,direction dir)
        {
            Point a = new Point(x, y, sym);
            f = dir;
            monster_list.Add(a);
            Point a1 = new Point(x - 1, y-1, sym);
            monster_list.Add(a1);
            Point a2 = new Point(x + 1, y - 1, sym);
            monster_list.Add(a2);
        }
        public List<Point> get_monster()
        {
            return monster_list;
        }
        public void Move(List<Point> pp,List<Point> vertical)
        {
            Point a = new Point();


            Point buf = new Point();


            if (buf.checking(monster_list, pp))
            {
                if (f == direction.LEFT)
                {

                    f = direction.REIGTH;
                }
                else 
                {

                    f = direction.LEFT;
                }

            }
            if (((monster_list[0].get_x()) % 6) == 0)
            {
                Point fire_1 = new Point(monster_list.First().get_x(), 5, '@');
                fire.Add(fire_1);

            }
            for(int i = 0; i < monster_list.Count ; i++)
            {
                buf= monster_list[i];
                buf.clean(monster_list[i]);
                monster_list[i] = a.next(monster_list[i], f);
                
               

            }
            for(int i =0; i < fire.Count; i++)
            {
               
                
                    buf = fire[i];
                    buf.clean(fire[i]);
                    fire[i] = a.next(fire[i], direction.DOWN);
                if (monster_fire_line(vertical)) ;


                }
            
        }

       
        
        public bool monster_fire_line (List<Point> lines)
        {
            Point a = new Point();
            if(a.checking(fire, lines))
            {
               a.clean( a.check_point(fire, lines));
                fire.Remove(a.check_point(fire, lines));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
