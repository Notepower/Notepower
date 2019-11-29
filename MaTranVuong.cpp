#include <stdio.h>
#define MAXC 10
#define MAXD 10
void NhapMaTran (int a[][MAXC],int &n)
{
	do
	{printf("Nhap vao cap cua ma tran: ");
	scanf("%d",&n);}
	while (n<=1 || n>=MAXD);
	int i,j;
	for (i=0;i<n;i++)
	{
		for (j=0;j<n;j++)
		{
		printf("Nhap a[%d][%d]:",i,j);
		scanf("%d",&a[i][j]);
		}
	}
}
void XuatMaTran (int a[][MAXC],int n)
{
	printf("Ma tran vua nhap:\n");
	for (int i=0;i<n;i++)
		{
			for (int j=0;j<n;j++)
			printf("%d  ",a[i][j]);
			printf("\n");
		}
}
int TongDCC (int a[][MAXC],int n)
{
	int s=0;
	for (int i=0;i<n;i++)
		{
			for (int j=0;j<n;j++)
			if (i==j)
			s=s+a[i][j];
		}
return s;
}
void HienThid(int a[][MAXC],int n,int d)
{
	printf("\nNhap vao dong can hien thi :");
 	scanf("%d",&d);
	for (int j=0;j<n;j++)
	{
		printf("%d\t",a[d][j]);
	}
}
int main()
{
 int a[MAXD][MAXC];
 int n,d;
 NhapMaTran (a,n);
 XuatMaTran (a,n);
 printf("Tong cac phan tu tren duong cheo chinh la %d",TongDCC(a,n));
 HienThid(a,n,d);
//return 0;

}

