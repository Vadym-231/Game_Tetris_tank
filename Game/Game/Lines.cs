using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Lines
    {
        int x, y;
        char sym;
        
        List<Point> vertical_list = new List<Point>();
        List<Point> horizontal_list = new List<Point>();
        public Lines(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            vertical();
            horizontal();
        }
        void vertical()
        {
            for (int i = 2; i < y; i++)
            {
                Point a = new Point(2, i, sym);
                vertical_list.Add(a);

            }
            for (int i = 2; i < y; i++)
            {
                Point a1 = new Point(x, i, sym);
                vertical_list.Add(a1);
            }
        }
        void horizontal()
        {
            for (int i = 2; i < x; i++)
            {
                Point a = new Point(i, 2, sym);
                horizontal_list.Add(a);

            }
            for(int i = 2; i < x; i++)
            {
                Point a1 = new Point(i, y, sym);
                horizontal_list.Add(a1);
            }

        }
       public List<Point> get_List()
        {
            return vertical_list;
        }
        public List<Point> Get_vertical_list()
        {
            return horizontal_list;
        }
       
        
        public Lines()
        {

        }

        
        
    }
}
