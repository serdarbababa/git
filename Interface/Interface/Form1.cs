using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using veritipi = System.Int16;
namespace Interface
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public veritipi [,] generateData(int totalSize, int[] distribution)
        {
            veritipi[,] data = { //{ 1 }, { 2 }, { 3 }, { 4 }, { 5 } };
                               {1, 0, 1,0, 1, 0,0, 0, 0,0, 1, 0,0, 1, 0},
					    {0, 0, 1,0, 1, 0,0, 0, 1,0, 1, 0,0, 0, 1},
					    {0, 0, 0,0, 1, 1,0, 1, 1,0, 1, 1,0, 0, 0},
					    {0, 0, 1,0, 1, 0,0, 1, 0,0, 1, 0,0, 0, 1},
					    {0, 0, 0,0, 1, 1,0, 0, 1,0, 1, 1,0, 0, 0},
					    {0, 0, 0,0, 1, 1,0, 0, 1,0, 1, 1,0, 1, 1},
					    {0, 0, 0,0, 1, 1,0, 1, 1,0, 1, 0,0, 0, 0},
					    {0, 1, 0,0, 1, 0,0, 0, 0,0, 1, 0,0, 1, 0},
					    {0, 0, 0,1, 0, 1,1, 0, 1,1, 0, 1,0, 0, 0},
					    {0, 0, 0,1, 1, 0,1, 1, 0,0, 1, 0,0, 0, 0},
					    {0, 1, 0,0, 0, 1,0, 1, 1,0, 0, 1,0, 1, 0},
					    {0, 1, 1,0, 1, 1,0, 1, 1,0, 1, 1,0, 0, 0},
					    {0, 1, 0,0, 0, 0,0, 1, 0,0, 1, 0,0, 1, 0},
					    {0, 1, 0,0, 0, 0,0, 0, 0,0, 0, 0,0, 1, 0},
					    {1, 0, 1,0, 1, 0,0, 1, 0,0, 1, 0,1, 0, 1},
					    {0, 0, 0,0, 1, 0,0, 0, 0,0, 1, 1,0, 1, 1},
					    {1, 0, 1,0, 1, 0,0, 1, 0,1, 0, 1,1, 1, 0},
					    {0, 0, 1,0, 1, 0,0, 0, 0,0, 0, 1,0, 1, 0},
					    {1, 0, 0,0, 1, 1,1, 0, 1,1, 1, 0,0, 0, 1},
					    {0, 0, 0,1, 0, 1,1, 0, 1,1, 0, 1,1, 0, 1},
					    {0, 1, 0,0, 1, 0,0, 1, 0,0, 1, 0,0, 0, 0},
					    {0, 1, 0,0, 1, 0,0, 1, 0,0, 1, 0,1, 0, 1},
					    {0, 1, 0,0, 1, 0,0, 1, 0,0, 0, 0,0, 1, 0},
					    {0, 1, 0,0, 1, 0,1, 0, 1,0, 1, 0,0, 1, 0},
					    {0, 1, 0,0, 1, 0,1, 0, 1,1, 0, 1,1, 0, 1},
					    {0, 0, 0,1, 1, 0,1, 0, 1,0, 1, 1,0, 0, 0}};//*/
            veritipi[,] rdata = new veritipi[totalSize, data.GetLength(1)];
            
            int sum = 0;
            for(int i = 0 ; i < distribution.Length; i++)
                sum+=distribution[i];

            int index  =0;
            int tempsum = distribution[index]; ;

            for (int i = 0; i < totalSize; i++)
            {
                if (i % sum >= tempsum)
                {
                    index++;
                    tempsum += distribution[index];
                    
                }
                    
                //double tempSum=0;
                //for (int j = 0; j < index + 1; j++)
                //    tempSum += distribution[j];

                //if (i % sum >= tempSum)
                //    index++;
                if (i % sum == 0)
                {
                    index = 0;
                    tempsum = distribution[index]; ;
                }

                for (int j = 0; j < data.GetLength(1); j++ )
                    rdata[i, j] = data[index, j];

            }

            return rdata;

        }

        public void printData(veritipi [,]veri)
        {
            for (int i = 0; i < veri.GetLength(0); i++)
            {
                txtOutput.AppendText(i + "\t");
                for (int j = 0; j < veri.GetLength(1); j++)
                {
                    txtOutput.AppendText(veri[i, j] + " ");
                }
                txtOutput.AppendText("\n");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] distribution = {1,2,1,2};
            veritipi [,]veri = generateData(10, distribution);
            printData(veri);

        }

        private void btnUnitNeuronTest_Click(object sender, EventArgs e)
        {
            Nod n = new Nod(0);
            for (int i = 0; i < 15; i++)
            {
                n.input = 1;
                if (i % 5 == 0)
                    n.input = 0;
                n.update();
                n.act();
                txtOutput.AppendText(n.toString()+"\n");
            }

        }

        private void btnNetTest1_Click(object sender, EventArgs e)
        {
            Net n = new Net(15, 5, 4);
            n.doConnections(0);
            //txtOutput.AppendText(n.toString());
            int[] distribution = { 1, 2, 1, 2 };
            veritipi[,] veri = generateData(100, distribution);
            //printData(veri);
            string trainResult = "";
            for (int i = 0; i < veri.GetLength(0); i++)
            {
                veritipi[] temp = new veritipi[15];
                for (int j = 0; j < veri.GetLength(1); j++)
                {
                    temp[j] = veri[i, j];
                }
                //trainResult += n.train(temp)+"\n";
                string tempStr = n.train(temp);
                txtOutput.AppendText(tempStr + "\r\n");
                //txtOutput.AppendText(((Nod)n.nodes[15]).toString() + "\n");
                //txtOutput.AppendText(((Nod)n.nodes[20]).toString() + "\n");
            }

        }


    }
}
