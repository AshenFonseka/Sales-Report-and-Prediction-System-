#include <stdio.h> 
#include <stdlib.h> 
#include <time.h>


void SelecSort(int f[],int size); 
void output(int e[],int size);


int main(){
      
        int e , f;
        int v[20] = {2,4,2,4,6,8,10,16,14,12,90,68,56,134,67,45,23,65,87,30};
        int u[20] = {43,65,40,4,87,7,81,91,89,54,66,45,70,42,20,21,30,32,29,27};
        int t[20] = {4,8,12,12,28,38,48,60,72,84,84,110,130,136,150,172,188,200,242,282};
        int s[20] = {999,853,525,401,375,253,185,179,153,138,99,79,63,51,44,32,18,7,5,1};
        int r[20] = {5,5,59,7,49,11,93,21,67,67,33,91,11,69,57,27,7,69,63,17};
        int q[20] = {1,3,5,7,9,11,13,15,17,19,21,33,45,67,69,73,75,81,91,97};
        int p[20] = {962,852,764,732,624,500,420,354,282,180,,82,80,64,60,54,46,34,30,2}; 
        int o[20] = {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40};
        int m[20] = {3,7,13,43,65,87,89,91,93,101,123,137,143,145,157,159,163,171};
        int n[20] = {34,56,32,32,8,64,36,66,80,54,60,46,78,90,72,56,48,6};



output(v,20); 
SelecSort(v,20); 
output(u,20); 
SelecSort(u,20); 
output(t,20); 
SelecSort(t,20); 
output(s,20); 
SelecSort(s,20); 
output(r,20); 
SelecSort(r,20); 
output(q,20); 
Selecort(q,20); 
output(p,20); 
SelecSort(p,20); 
output(o,20); 
SelecSort(o,20); 
output(m,20); 
SelecSort(m,20); 
output(n,20); 
SelecSort(n,20);
}

void output(int e[],int size){
        printf("\n\n<<<<<<<---------integers before sorting---------->>>>>>>\n");
 for (int m = 0; m < size; m++) { 
    printf("%d\t",e[m]);

 } 

}


void SelecSort(int f[],int size){
        int m,n,o;
        for (m=0;m<size;m++){
             
             int min,temp; 
             min=m; 
             for(o=m+1;o<size;++o){
                    if (f[o] < f[min])
                                min=o;
            }
            temp = f[m]; 
            f[m] = f[min]; 
            f[min] = temp;
    }

for(m=0;m<size;m++){

            for(o=m+1; o<size; o++) 
    {
        
        if(f[m] == f[o])
      {
       
        for(n=o; n<size; n++)
       {
         f[n] = f[n + 1]; 
       }

    
    }
  } 
}

          printf("\n<<<<<<<---------integers after sorting---------->>>>>>>\n");
for(m=0;m<size;m++){
     printf("%d\t", f[m]);
 }
}