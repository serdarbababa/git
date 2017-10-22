#pragma once
#include <vector>
#include <ctime>
using namespace std;

class node
{
	static int ID;
	int id;
	
	int		M  ;		// the number of synapses per neuron  100
	int		D  ;		// maximal axonal conduction delay 20
	float	sm;		// maximal synaptic strength	
	
	vector<node	*> *post;	// indeces of postsynaptic neurons
	vector <float> *postW;

	float	*s, *sd;		// matrix of synaptic weights and their derivatives
	short	*delays_length;	// distribution of delays
	short	*delays;		// arrangement of delays   

	int		N_pre, *I_pre, *D_pre;	// presynaptic information
	float	*s_pre, *sd_pre;		// presynaptic weights
	float	*LTP, LTD;	// STDP functions 

	float	a, b, c, d;				// neuronal dynamics parameters
	float	v, u;				// activity variables
	bool exitatory_node_type;

public:
	node(void);
	node(int);
	node(float a, float b, float c, float d);
	~node(void);
	void addPostSyn(node * nod);
	void setInputSpike();
	void trigger();
	void getTrigger();
	void getOutput();

	void toString();

};

