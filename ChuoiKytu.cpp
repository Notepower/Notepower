#include <stdio.h>
#include <string.h>
int DX(char s[])
{
	int n = strlen (s);
	for (int i=0;i<n/2;i++)
		if (s[i]!=s[n-1-i]) return 0;
	return 1;
}
int main()
{
	char s[100];
	printf("Nhap vao 1 chuoi: ");
	gets(s);
		for (int i=0;i<strlen(s);i++)
			{
				printf("\n Ma ASCII cua %c la %d",s[i],s[i]);
			}
	//in ra cac ky tu tren moi dong
	printf("\nCac ky tu trong chuoi la :\n");
		for (int i=0;i<strlen(s);i++)
			{
			printf("%c",s[i]);
			printf("\n");
			}
	int dem=0;
	printf("\nSo nguyen am cua ky tu la: ");
		for (int i=0;i<strlen(s);i++)
			/*
			if (s[i]=='a'||s[i]=='e'||s[i]=='u'||
			s[i]=='o'||s[i]=='i'||s[i]=='E'||
			s[i]=='U'||s[i]=='O'||s[i]=='A'||
			s[i]=='I') dem=dem+1;
			*/
		switch (s[i])
		{
			case 'a':
			case 'e':
			case 'u':
			case 'o':
			case 'i':
			case 'E':
			case 'U':
			case 'O':
			case 'A':
			case 'I': dem++;
		}
		printf("\n%d",dem);
		printf("\nIn ra ky tu tu dong den cuoi la :");
		for (int i=strlen(s);i>=0;i--)
			{
				printf("%c",s[i]);
				printf("\n");}
	int kq=DX(s);
	if (kq==1) printf("Chuoi ky tu doi xung");
	if (kq==0) printf("Chuoi ko doi xung");
return 0;
}
