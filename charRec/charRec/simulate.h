#pragma once
#include "net.h"
class simulate
{
	net *n;
public:
	simulate(void);
	~simulate(void);
	void work();
	void one_slice_of_time();
};

