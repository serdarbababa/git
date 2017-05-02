using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritipi = System.Int16;

namespace Interface
{
    class Net
    {
        public ArrayList nodes = new ArrayList();
        int inputs;
        int outputs;
        int hiddens;
        int propagationPeriod ;
        public Net(int input, int hidden, int output)
        {
            for (int i = 0; i < input+hidden+output; i++)
                nodes.Add(new Nod(i));
            this.inputs = input;
            this.hiddens = hidden;
            this.outputs = output;
            this.propagationPeriod = 5;
        }

        public void doConnections(int option)
        {
            if (option == 0)
            {
                for (int i = 0; i < this.inputs; i++)
                    for (int j = 0; j < this.hiddens; j++)
                        ((Nod)this.nodes[i]).post.Add(((Nod)this.nodes[this.inputs + j]));
                for (int i = 0; i < this.hiddens; i++)
                    for (int j = 0; j < this.outputs; j++)
                        ((Nod)this.nodes[this.inputs+i]).post.Add(((Nod)this.nodes[this.inputs+ this.hiddens + j]));
            }
        }
        
        public string train(veritipi[] pat)
        {
            string res = "";

            
            for (int j = 0; j < this.propagationPeriod; j++)
            {
                for (int i = 0; i < inputs; i++)
                    ((Nod)nodes[i]).input+= pat[i];
                for (int i = 0; i < nodes.Count; i++)
                {
                    ((Nod)nodes[i]).update();
                }
                for (int i = 0; i < nodes.Count; i++)
                {
                    ((Nod)nodes[i]).act();
                }
                res += getOutput() + "\n";
            }
            

                return res;
        }
        public string toString(){
            string res="";
            for (int i = 0; i < this.nodes.Count; i++)
            {
                res+=((Nod) nodes[i]).id+"\t[ ";
                for (int j = 0; j < ((Nod)nodes[i]).post.Count; j++)
                    res += ((Nod)((Nod)nodes[i]).post[j]).id + " ";
                res += "]\r\n";
            }
            return res;
        }
        public string getOutput()
        {
            string res = "";
            for (int i = inputs + hiddens; i < nodes.Count; i++)
            {
                if (((Nod)this.nodes[i]).fired())
                    res += "x ";
                else
                    res += "0 ";
            }
            return res;
        }

    }
}
