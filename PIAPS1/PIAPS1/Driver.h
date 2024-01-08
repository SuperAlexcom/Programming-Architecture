#pragma once
#include <iostream>
using namespace std;
class Passenger
{
public:
	Passenger() { cout << "Passenger is created\n"; };
	
};

enum Licenze { BCategory, DCategory };
class Driver {
	public:
	Licenze licenze;
	Driver() {};
};

class TaxiDriver : public Driver
{
public:
	TaxiDriver()
	{
		cout << "TaxiDriver is created\n";
		licenze = BCategory;
	}
};

class BusDriver : public Driver {
	BusDriver() {
		cout << "BusDriver is created\n";
		licenze = DCategory;
	}
};



