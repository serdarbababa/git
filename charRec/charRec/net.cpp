#include "net.h"


net::net(void)
{
	this->layers=new vector < vector <node *>*>;

	this->Ne = 800;		// excitatory neurons			
	this->Ni = 200;		// inhibitory neurons				 
	this->N  = Ne+Ni;		// total number of neurons	
}


net::~net(void)
{
}


void net::initialize(int * nodeCounts, int size ){
	for(int i = 0 ; i < size;i++){
		vector <node*> *layer = new vector<node * >;
		for(int j = 0; j < nodeCounts[i*2];j++)
		{
			node *n = new node(1);
			layer->push_back(n);
		}
		for(int j = 0; j < nodeCounts[i*2+1];j++)
		{
			node *n = new node(-1);
			layer->push_back(n);
		}

		this->layers->push_back(layer);
	}
	//nodes.push_back(9);
	//nodes.push_back(4);

}
void net::toString(){
	for(int i = 0 ; i < this->layers->size();i++){
		printf("layer = %d has %d nodes\n", i,this->layers->at(i)->size() );
		for(int j =0;j<this->layers->at(i)->size();j++)
			this->layers->at(i)->at(j)->toString();
	}
}