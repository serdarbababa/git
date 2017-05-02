using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritipi = System.Int32;

namespace Interface
{
    class Nod
    {
        public int id;
        public int input;
        double energy;
        double threshold;
        short history;
        ArrayList pre;
        public ArrayList post;
        static short historyDefault= 20;
        static short thresholdDefault=7;

        public Nod(int id)
        {
            this.id = id;
            energy = 0;
            threshold = thresholdDefault;
            history = historyDefault;
            input = 0;
            pre = new ArrayList();
            post = new ArrayList();
        }
        
        public void update()
        {
            if (history < historyDefault)
                history++;

            if (input > 0)
            {
                energy+=input;
                if (energy >= threshold)
                {
                    energy = 0;
                    history = 0;
                }                
            }
            else if(energy >0.2)                       
                energy -= 0.2;
            input = 0;
        }

        public void act()
        {
            if (history == 0)
            {
                for (int i = 0; i < post.Count; i++)
                    ( (Nod)post[i] ).input++;
            }
        }

        public string toString()
        {
            return "id = " +id+" energy = " + energy + " history = " + history;
        }
        /*double energy;
        double threshold = 10;
        bool fired = false;
        ArrayList patterns = new ArrayList();
        ArrayList patternsCount = new ArrayList();
        ArrayList tempPatterns = new ArrayList();
        ArrayList tempPatternsCount = new ArrayList();


        public void train(veritipi[] pat)
        {
            if( patterns.Contains(pat))
            {
                int index = patterns.IndexOf(pat);
                patternsCount[index] = (int)patternsCount[index] + 1;
            }
            else if(tempPatterns.Contains(pat))
            {
                int index = tempPatterns.IndexOf(pat);
                tempPatternsCount[index] = (int)tempPatternsCount[index] + 1;
            }
            else
            {
                tempPatterns.Add(pat);
                tempPatternsCount.Add(0);
            }

        }

        public void update(veritipi[] pat)
        {
            if (pat[0] == 1)
            {
                energy++;
                if (energy > threshold)
                {
                    energy = 0;
                    fired = true;
                }
            }
            else
            {
                energy -= 0.2;
                fired = false;
            }
        }
        */

        public bool fired()
        {
            if (history == 0)
                return true;
            else
                return false;
        }
    }
}
