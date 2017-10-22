#pragma once
#include "node.h"

class net
{

	vector < vector <node *>*> * layers;
	//vector<node> nodes;
	

	int		Ne;		// excitatory neurons			
	int		Ni;		// inhibitory neurons				 
	int		N ;		// total number of neurons	
public:
	net(void);
	~net(void);
	void initialize(int * nodeCounts, int size );
	void toString();
};

