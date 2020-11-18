#include <stdio.h>
int n=7;
int a[20];
void kt_in()
{
	int S=0;
	for (int k=0;k<=n;k++)
		if(a[k]!=0)	S=S+a[k];
	if (S==n)
	{
	for (int k=0;k<=n;k++)
	{
		if (a[k]!=0)
		printf("%2d",a[k]);
	}
	printf("\n");
		}

}
void thu(int i,int n)
{ int j;
	 for (j=1;j<=n;j++)
	 {
	 a[i]=j;
	 if ((n-a[i])>0)
	 {
	 thu(i+1,n-j);
}
	 else
	 kt_in();
	 a[i]=0;
	 }
}
//------------------------
int main ()
{
thu(1,n);
return 0;
}
