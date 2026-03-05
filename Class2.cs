using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    public struct Seat
    {
        public char row;
        public int number;

        public Seat(char row, int number)
        {
            this.row = row;
            this.number = number;
        }
        public override string ToString()
        {
            return $"{row}{number}";
        }
    }
}
