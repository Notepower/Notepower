#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
typedef struct
{ 
	int Ngay;
	int Thang;
	int Nam;
}
	NgayThang;
typedef struct
{ 
	int MaNV;
	char HoTen[40];
	NgayThang NgaySinh;
}
	NhanVien;
//h�m nh?p 1 m?u tin nh�n vi�n
void NhapNV(NhanVien &nv)
{ 
	printf("\nNhap Ma nhan vien: ");scanf("%d",&nv.MaNV);
	fflush(stdin);
	printf("Nhap Ho va ten: ");gets(nv.HoTen);
	printf("Sinh ngay: ");scanf("%d",&nv.NgaySinh.Ngay);
	printf("Thang: ");scanf("%d",&nv.NgaySinh.Thang);
	printf("Nam: ");scanf("%d",&nv.NgaySinh.Nam);
}
//h�m hi?n th? 1 m?u tin nh�n vi�n
void InNV(NhanVien nv)
{ 
	printf("%5d| %5s | %d-%d-%d \n",nv.MaNV, nv.HoTen, nv.NgaySinh.Ngay,
	nv.NgaySinh.Thang, nv.NgaySinh.Nam);
}
//h�m nh?p 1 danh s�ch nh�n vi�n
void NhapDSNV(NhanVien nv[],int &n)
{
 	printf("So nhan vien: "); scanf("%d",&n);
	 for (int i = 0; i < n; i++)
 {
  	printf("\nNhap thong tin nhan vien thu %d",i+1);
 	NhapNV(nv[i]);
 }
}
//h�m xu?t 1 danh s�ch nh�n vi�n ra m�n h�nh
void InDSNV(NhanVien nv[], int n)
{ 
	printf("\nMNV: | Ho va ten | Ngay Sinh \n");
 	for (int i = 0; i < n; i++)
 { 
 	InNV(nv[i]);
 	printf("\n");
 }
}
int main()
{ NhanVien NV, DSNV[20];
	int n;
	NhapDSNV(DSNV,n);
	InDSNV(DSNV,n);
}

