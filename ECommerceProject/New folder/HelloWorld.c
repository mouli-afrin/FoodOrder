#include<stdio.h>


int main()
{
    int i, year;

    scanf("%d",&year);

    if(year%400 == 0 || (year%100!=0 && year%4==0))
    {
            printf("LeapYear");
    }
    else
    {
        printf("Not");
    }


    return 0;

}
