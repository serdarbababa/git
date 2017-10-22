#include "node.h"

int node::ID=0;

node::node(void)
{
	id=ID++;
	M  = 100;
	D=20;
	this->sm = 10.0;
	this->a=0.02;
	this->b=0.2;
	this->c=-55;
	this->d=4;
	this->v=-65.0;
	this->u=0.2*this->v;
	this->post=new vector<node*>;
	this->postW=new vector<float >;
	this->exitatory_node_type=true;
}
node::node(int type){
	id=ID++;
	M  = 100;
	D=20;
	this->sm = 10.0;
	if(type==1){
		this->a=0.02;
		this->b=0.2;
		this->c=-55;
		this->d=4;
		this->exitatory_node_type=true;
	}
	else{
		this->a=0.06;
		this->b=0.22;
		this->c=-65;
		this->d=2;
		this->exitatory_node_type=false;
	}

	this->v=-65.0;
	this->u=0.2*this->v;
	this->post=new vector<node*>;
	this->postW=new vector<float >;
}
node::node(float a, float b, float c, float d){
	id=ID++;
	this->sm=10;
	this->a=a;
	this->b=b;
	this->c=c;
	this->d=d;
	this->v=-65.0;
	this->u=0.2*this->v;
}
node::~node(void)
{
}

void node::setInputSpike(){

}

void node::addPostSyn(node * nod){
	this->post->push_back(nod);
	srand(time(NULL));
	this->postW->push_back(((float)rand())/(RAND_MAX*5)+0.4);
}

void node::trigger(){
	for(int i =0;i< this->post->size();i++)
		this->post->at(i)->getTrigger();
}

void node::getTrigger(){

}

void node::toString(){
	printf("\tnode id = %d excitatory type = %d has %d post\n", this->id, this->exitatory_node_type, this->post->size() );
	//for(int i =0;i<this->post.size();i++)
	//	printf()
}

void node::getOutput(){
	if(this->post->size()==0)
		printf("output is 1" );
}
