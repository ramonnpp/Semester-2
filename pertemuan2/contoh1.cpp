#include <iostream>
using namespace std;

int main(void){
	int a,*b;
	
	a=5;
	b=&a;
	cout<<"nilai a : "<<a;
	cout<<"\nnilai yang ditunjukan oleh b :"<<*b;
	
	cout<<"\nalamat a : "<<&a;
	cout<<"\nalamat yang ditunjukkan oleh b : "<<b;
	
	return 0;
}