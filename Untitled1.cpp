#include<iostream>
using namespace std;
int a[100];

	

int main()
{
	long long n,tach,phu;
	tach=0;
	phu=0;
	cin>>n;
	int i=0;
	long long dem=0;
		while(n>0)
	{
		phu++;
		tach=n%10;
		a[i]=tach;
		i++;
		n=n/10;
	}
	for(i=0;i<phu;i++)
	{
		for(int j=0;j<phu;j++)
		{
			if(a[i]==a[j]) dem++;
			break;
		}
	}
	if(phu==dem)cout<<"YES";
	else cout<<"NO";
 return 0;
}
