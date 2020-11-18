#include<stdio.h>
int a[]={0,1};
int b[20];
int n=5;
void kt_in()
{
	int A=0;
	int B=0;
	for (int k=0;k<n;k++)
	{
		if(b[k]==1) A++;
		else B++;		
	}
	if (A>=3 || B<=2)
	{
		printf("A Wins: ");
	for (int k=0;k<5;k++)
	{
		if(b[k]==1) printf("A ");
		else printf("B ");		
	}

}
	if (B>=3 || A<=2)
	{
		printf("B Wins: ");
	for (int k=0;k<5;k++)
	{
		if(b[k]==1) printf("A ");
		else printf("B ");		
	}

}
	printf("\n---------------------\n");
}

void thu(int i)
{
	for (int j=0;j<2;j++)
	{
		b[i]=a[j];
		if (i<n-1) thu(i+1);
		else
		{
			kt_in();
		}
	}
}




int main()
{
	thu(0);
 return 0;
}

