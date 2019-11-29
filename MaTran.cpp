#include <stdio.h>
#define MAXC 10
#define MAXD 10
void NhapMaTran (int a[][MAXC],int &m,int &n)
{
	do{
	printf("Nhap so dong,so cot cua ma tran: ");
	scanf("%d%d",&m,&n);}
	while (m<=0 || m>10 || n<=0 || n>=10);
	int i,j;
	for (i=0;i<m;i++)
			for (j=0;j<n;j++)
			{
				printf("Nhap a[%d][%d]: ",i,j);
				scanf("%d",&a[i][j]);
			}
}
void XuatMaTran (int a[][MAXC],int m,int n)
{
	printf("Ma tran vua nhap:\n");
	for (int i=0;i<m;i++)
		{for (int j=0;j<n;j++)
			printf("%d  ",a[i][j]);
			printf("\n");}
}
int NguyenTo(int n)
{
	int dem=0;
	for (int i=1;i<=n;i++)
	{
		if (n%i==0)
		dem++;
	}
	if (dem==2) return 1;
	return 0;
}
int KTNguyenTo (int a[][MAXC],int m,int n)
{
	int i,j;
	for (i=0;i<m;i++)
		for (j=0;j<n;j++)
			if (NguyenTo(a[i][j])==0)
			return 0;
	return 1;
}
int TimKiem(int a[][MAXC],int m,int n,int x)
{
	int i,j;
	for (i=0;i<m;i++)
		for (j=0;j<n;j++)
	{
		if (a[i][j]==x) 
		return 1;
	}
return 0;
}
int KiemTraBoi(int a[][MAXC],int m,int n)
{
	int i,j;
	int dem=0;
	for (i=0;i<n;i++)
		for (j=0;j<m;j++)
	{
		if ((a[i][j])%3==0)
		dem++;
	}
	if (dem==m*n) return 1;
	return 0;
}
int TongDong(int a[][MAXC],int &d,int n)
{
	int j,s;
	s=0;
	for (j=0;j<n;j++)
	s=s+a[d][j];
	return s;
}
int TongCot(int a[][MAXC],int m,int &c)
{
	int i,s;
	s=0;
	for (i=0;i<m;i++)
	s=s+a[i][c];
	return s;
}
int main()
{
int a[MAXD][MAXC];
int n,m,x,kq,kq1,kq2,tongd,tongc,d,c;
NhapMaTran (a,n,m);

XuatMaTran (a,n,m);
	printf("Nhap phan tu x: ");
	scanf("%d",&x);
	
	kq=TimKiem(a,n,m,x);
	if (kq==1) printf("\n%d thuoc ma tran",x);
	if (kq==0) printf("\n%d khong thuoc ma tran",x);
	
	kq1=KTNguyenTo(a,n,m);
	if (kq1==1) printf("\nMa Tran toan so nguyen to ");
	if (kq1==0) printf("\nMa Tran khong toan so nguyen to");
	
	kq2=KiemTraBoi(a,n,m);
	if (kq2==1) printf("\nMa Tran toan boi cua 3 ");
	if (kq2==0) printf("\nMa Tran khong toan boi cua 3");
	
	do{
	printf("\nNhap so dong can tinh:");
	scanf("%d",&d);
	}
	while (d<0 || d>=m);
	tongd=TongDong(a,d,n);
	printf("S=%d",tongd);
	do{
	printf("\nNhap so cot can tinh:");
	scanf("%d",&c);
	}
	while (c<0 || c>=n);
	tongc=TongCot(a,m,c);
	printf("S=%d",tongc);
}

