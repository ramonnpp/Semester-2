#include <iostream>
using namespace std;

int main(){
	string a [2];
	for (int i = 0; i<2;i++){
		cout<<"Masukkan Nilai index ke-"<<i+1<<" = ";
		cin>>a[i];
	}
	cout<<endl;
	for (int n = 0; n<2; n++){
		cout<<"Index ke-"<<n+1<<" = "<<a[n]<<endl;
	}
	return 0;
}


