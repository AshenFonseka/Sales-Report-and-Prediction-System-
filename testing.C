# include <stdio.h>
#include <stdlib.h>
#include <time.h>


void SortFunction(int y[],int NoOfValues);
void OutputArray(int x[],int NoOfValues);
int main()
{
    int x , y;
    int list1[20] = {14,36,3,5,18,80,29,92,19,38,77,24,27,9,2,62,13,83,22,15};
    int list2[20] = {37,6,37,6,56,9,1,5,6,9,95,14,75,91,29,40,29,71,57,6};
    int list3[20] = {890,876,774,666,590,562,494,428,382,270,152,140,96,32,24,12,10,8,4,2};
    int list4[20] = {1,3,7,11,11,25,25,37,49,49,71,83,83,93,119,127,127,175,175,175};
    int list5[20] = {990,875,770,660,590,560,470,430,360,250,150,140,90,75,50,30,25,15,10,5};
    int list6[20] = {3,6,6,6,9,9,15,18,27,36,36,57,57,63,69,75,75,90,93,104};
    int list7[20] = {4,16,5,18,70,9,19,98,157,124,7,39,22,52,83,27,13};
    int list8[20] = {35,7,35,7,6,19,1,5,19,19,141,55,9,291,12,29,6};
    int list9[20] = {810,856,844,646,570,542,476,416,342,260,142,128,46,42,12,10,6};
    int list10[20] = {1,7,7,11,17,25,35,49,49,49,93,93,119,119,149,171,193};
  
    OutputArray(list1,20);
    SortFunction(list1,20);
    OutputArray(list2,20);
    SortFunction(list2,20);
    OutputArray(list3,20);
    SortFunction(list3,20);
    OutputArray(list4,20);
    SortFunction(list4,20);
    OutputArray(list5,20);
    SortFunction(list5,20);
    OutputArray(list6,20);
    SortFunction(list6,20);
    OutputArray(list7,20);
    SortFunction(list7,20);
    OutputArray(list8,20);
    SortFunction(list8,20);
    OutputArray(list9,20);
    SortFunction(list9,20);
    OutputArray(list10,20);
    SortFunction(list10,20);
}

void OutputArray(int x[],int NoOfValues)
{
    printf("\n\n:Input Values to sort-->");
    for (int a = 0; a < NoOfValues; a++) 
    {
        printf("%d\t",x[a]);
    }
}

void SortFunction(int y[],int NoOfValues)
{
    int a,b,c;
    for (a=0;a<NoOfValues;a++)
    {
        int minimum,tmp;
        minimum=a;
        for(c=a+1;c<NoOfValues;++c)
        {
            if (y[c] < y[minimum])
            minimum=c;
        }
        tmp = y[a];
        y[a] = y[minimum];
        y[minimum] = tmp;
    }
    
    for(a=0;a<NoOfValues;a++)
    {
        for(c=a+1; c<NoOfValues; c++)
        {   
            
            if(y[a] == y[c])
            {

                for(b=c; b<NoOfValues; b++)
                {
                    y[b] = y[b + 1];
                }

                NoOfValues--;
                c--;
            }
        }
    }

    printf("\n\n:Output Values after sorting-->");
    for(a=0;a<NoOfValues;a++)
    {
        printf("%d\t", y[a]);
    }
}