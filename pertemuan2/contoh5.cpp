#include <iostream>
#include <conio.h>
using namespace std;
int tukarvalue(int *x, int *y);

int main(){
	int a,b;
	cout<<"Passing by value\n";
	cout<<"\n\n";
	cout<<"inputkan nilai a = ";
	cin>>a;
	cout<<"inputkan nilai b = ";
	cin>>b;
	
	cout<<"\nNilai sebelum pemanggilan fungsi\n";
	cout<<"a = "<<a<<" b = "<<b;
	
	tukarvalue(&a,&b);
	
	cout<<"\nNilai setelah pemanggilan fungsi\n";
	cout<<"a = "<<a<<" b = "<<b;
	getch();
}

int tukarvalue(int *x,int *y)
{
	int z;
	
	z=*x;
	*x=*y;
	*y=z;
	cout<<"\nnilai diakhir fungsi tukar()\n";
	cout<<"x = "<<*x<<"y = "<<*y;
}
	