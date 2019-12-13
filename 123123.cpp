#include <stdio.h>
#define MAX 50
void NhapMang (int a[],int &n)
{
	do{
	printf("Nhap gia tri cua mang: ");
	scanf("%d",&n);}
	while (n<0 || n>50);
	for (int i=0;i<n;i++)
	{printf("\nPhan tu thu %d la ",i);
	scanf("%d",&a[i]);}
}
void XuatMang (int a[],int n)
{
	for (int i=0;i<n;i++)
		printf("%d  ",a[i]);
}
void HoanVi(int &a,int &b)
{
	int temp=a;
	a=b;
	b=temp;
}
void SapXepTang (int a[],int n)
{
	int i,j;
	for (i=0;i<n-1;i++)
		for (j=i+1;j<n;j++)
			{if (a[i] > a[j])
			HoanVi(a[i],a[j]);}
	XuatMang(a,n);
}
void SapXepGiam (int a[],int n)
{
	int i,j;
	for (i=0;i<n-1;i++)
		for (j=i+1;j<n;j++)
			{if (a[i] < a[j])
			HoanVi(a[i],a[j]);}
	XuatMang(a,n);
}
void SapXep (int a[],int n)
{
	int i,j;
	for (i=0;i<n-1;i++)
		for (j=i+1;j<n;j++)
		{ 	if(a[i]<0 || a[j]<0)
			{
				if (a[i] > a[j] )
				HoanVi(a[i],a[j]);
			}
			else if(a[i]>0 || a[j]>0)
			{
				if (a[i] < a[j] )
				HoanVi(a[i],a[j]);
			}
		}
	XuatMang(a,n);
}
int LaSNT (int n)
{
	int i,dem;
	dem=0;
	for (i=1;i<=n;i++)
	{if (n %i ==0) 
	dem=dem+1;}
	if (dem==2) return 1;
	return 0;
}
void TachSNT(int a[],int n,int b[],int &nb){
	nb=0;
	for (int i=0;i<n;i++)
		if (LaSNT(a[i])==1)
		{
			b[nb] = a[i];
			nb++;
		}
		XuatMang(b,nb);
}
int main()
{
	int a[MAX],b[MAX];
	int n,nb;
	NhapMang(a,n);
	printf("Mang tang dan la: ");
	SapXepTang(a,n);
	printf("\nMang giam dan la: ");
	SapXepGiam(a,n);
	printf("\nMang am tang,duong giam dan la ");
	SapXep (a,n);
	printf("\nMang tach nguyen to la :");
	TachSNT(a,n,b,nb);
//return 0;
}

