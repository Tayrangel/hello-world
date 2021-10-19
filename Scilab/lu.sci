function [x]=lu(A,b)
// Funcao que implementa o algoritmo LU
//
// A - matriz A
// b - vetor b
//
// Data: 29/03/2007
// por Antonio J G Cruz - DEQ/UFSCar    

// Utiliza a funcao ludecpiv.sci (esta funcao deve estar no mesmo diretorio)
getd;

[nl,nc]=size(A);
if (nl <> nc) then
    mprintf('Matriz nao eh quadrada');
    abort
end
N=nl;

// chamada da funcao que decompoe a matriz A (A=L*U)
[L,U,piv]=ludecpiv(A);

// resolucao do sistema triangular inferior (L*y=b)
b1=b(piv);
y(1)=b1(1)/L(1,1);

for i=2:N,
  soma=0.0;
    for j=1:i-1,
      soma=soma+L(i,j)*y(j);
    end
  y(i)=(b1(i)-soma)/L(i,i);
end  

// resolvendo o sistema triangualar superior (U*x=y)  
x(N)=y(N)/U(N,N);

for i=N-1:-1:1,
  soma=0.0;
    for j=i+1:N,
      soma=soma+U(i,j)*x(j);
    end
  x(i)=(y(i)-soma)/U(i,i);
end  

endfunction