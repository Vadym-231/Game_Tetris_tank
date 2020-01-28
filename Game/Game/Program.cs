using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void score()
        {
            Console.SetCursorPosition(52, 3);
            Console.Write("Score: 0");
        }
        static void Main(string[] args)
        {
            Lines a = new Lines(50,30,'*');
            Monster monster = new Monster(19,4,'0',direction.REIGTH);
            My_Tank tank = new My_Tank(35, 28, '0');
            score();
            
            do
           {
                tank.My_Tank_move(a.get_List(),a.Get_vertical_list());
                monster.Move(a.get_List(),a.Get_vertical_list());
                 if (monster.monster_fire_line(tank.get_tank_list()))
                 {
                     Console.Clear();
                     Console.WriteLine("YOU LOSE");
                     break;
                 }
                if (tank.check_lines(monster.get_monster()))
                {
                    Console.Clear();
                    Console.WriteLine("YOU WIN");
                    break;
                }
                System.Threading.Thread.Sleep(200);
                
            

            } while (true);

            Console.ReadKey();
        }
    }
}
