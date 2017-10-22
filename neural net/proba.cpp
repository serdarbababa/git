#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <math.h>
#include <vector>
#include <iomanip>

using namespace std;

struct struktura {
//       int k1, k2, k5, k6, k7, k10;
//       float k3, k4, k0;
//       string k8, k9;
         float k0, k1, k2, k3;
         int k4, k5;
};

vector<struktura> red;
int brojac=0;

ofstream myfile2 ("trainingData.txt");

/* **************** PROCEDURE ********************* */

void ucitajfajl() {
  string line;

  ifstream myfile ("podaci1.txt");

  if (myfile.is_open())
  {
    while ( myfile.good() )
    {
      brojac+=1;
      getline (myfile,line);

         istringstream stream1;
         stream1.str(line);
         red.push_back(struktura());
         stream1 >> red[brojac-1].k0 >> red[brojac-1].k1 >> red[brojac-1].k2 >> red[brojac-1].k3 >> red[brojac-1].k4 >> red[brojac-1].k5;
         
         if (brojac < 805) {
             myfile2 << "in: " << red[brojac-1].k0 << " " << red[brojac-1].k1 << " " << red[brojac-1].k2 << " " << red[brojac-1].k3 << endl;
             myfile2 << "out: " << red[brojac-1].k4 << ".0 " << red[brojac-1].k5 << ".0" << endl;
         }
//         cout << red[brojac-1].k0 << ", " << red[brojac-1].k1 << ", " << red[brojac-1].k2 << ", " << red[brojac-1].k3 << ", " << red[brojac-1].k4 << ", " << red[brojac-1].k5  << endl;

    }

    myfile.close();
  }
  else cout << "Unable to open file";
  
  brojac -= 2;
} //ucitajfajl()

int main () {

  myfile2 << "topology: 4 4 2" << endl;
  ucitajfajl();
  
  system("PAUSE");
  return EXIT_SUCCESS;  
}
