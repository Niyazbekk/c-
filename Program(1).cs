using System;

namespace LAB_T2_
{
    class Airplane 
    {
        private string name;
        private int fl_num;
        private string d_time;
        private string dest ;

        Airplane(string name , int fl_num , string d_time , string dest)
        {
            this.name = name;
            this.fl_num = fl_num;
            this.d_time = d_time;
            this.dest = dest;
        }
    }
    class Airport
    {
        private string[] airplane ;

        Airport(string[] airplane)
        {
            this.airplane = airplane;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Airplane air = new Airplane();
        }
    }
}
