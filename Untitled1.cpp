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
	printf("Nhap Ma nhan vien: ");scanf("%d",&nv.MaNV);
	fflush(stdin);
	printf("Nhap Ho va ten: ");gets(nv.HoTen);
	printf("Sinh ngay: ");scanf("%d",&nv.NgaySinh.Ngay);
	printf("Thang: ");scanf("%d",&nv.NgaySinh.Thang);
	printf("Nam: ");scanf("%d",&nv.NgaySinh.Nam);
}
//h�m hi?n th? 1 m?u tin nh�n vi�n
void InNV(NhanVien nv)
{ 
	printf("%5d| %d   | %d %d %d \n",nv.MaNV,nv.HoTen, nv.NgaySinh.Ngay,
	nv.NgaySinh.Thang, nv.NgaySinh.Nam);
}
int main()
{ 
	NhanVien NV;
	printf("Nhap thong tin cua nhan vien:\n");
	NhapNV(NV);
	printf("Thong tin cua nhan vien:\n");
	InNV(NV);
}


