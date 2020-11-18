#include<iostream>
using namespace std;
int a[]={1,2,3,4,5,6};
int n=sizeof(a)/sizeof(a[0])-1;
int b[20];
//-------------//
void kt_in ()
{
	int k;
	int S1=0;
	int S2=0;
	for (k=0;k<=n;k++)
		if (b[k]==0) S1=S1+a[k];
		else 
			if (b[k]==1) S2=S2+a[k];
	if ((S1-S2==1 || S2-S1==1) && (S1!=0))
	{
		cout<<"\n S1: ";
		for (k=0;k<=n;k++)
		if (b[k]==0) 
		{
			cout<<a[k]<<" ";

		}
		cout<<"\n S2: ";
		for (k=0;k<=n;k++)
		if (b[k]==1) 
		{
			cout<<a[k]<<" ";

		}
		cout<<endl;
	}
}
void thu (int i)
{
	int j;
	for (int j=0;j<=1;j++)
	{	b[i]=j;
		if (i<n) thu(i+1);
		else
		{
			kt_in ();
			b[i]=0;
		}
}
}
int main ()
	{
		thu(0);
		return 0;
	}
	
