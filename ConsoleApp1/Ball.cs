using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ball
    {
        int size;
        string color;
        string type;
        public int get_size()
        {
            return this.size;
        }
        public void set_size(int size)
        {
            this.size = size;
        }
        public string get_color()
        {
            return this.color;
        }
        public void set_color(string color)
        {
            this.color = color;
        }
        public string get_type()
        {
            return this.type;
        }
        public void set_type(string type)
        {
            this.type = type;
        }
    }
}
    

