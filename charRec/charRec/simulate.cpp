#include "simulate.h"


simulate::simulate(void)
{

}


simulate::~simulate(void)
{
}

void simulate::work(){
	n = new net();
	int layerNodes [6]={9,0,4,4,4,4}; 
	n->initialize(layerNodes,3);
	n->toString();
	this->one_slice_of_time();
	//n->toString();
}

void simulate::one_slice_of_time(){
	//n->initNet();
}