using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritipi = System.Boolean;


namespace Interface
{
    class Spektron
    {
        public int id;
        public veritipi[,] input;
        
        double energy;
        double threshold;
        
        ArrayList history;
        ArrayList historyCount;

        ArrayList prehistory;
        ArrayList prehistoryCount;

        ArrayList pre;
        public ArrayList post;        
        
        static short thresholdDefault = 7;

        public Spektron(int id)
        {
            this.id = id;

        }

    }
}
