function [L,U,piv]=ludecpiv(A);
// Funcao que retorna a decomposicao LU da matriz A com pivotamento
// Esta funcao eh chamada pela funcao lu.sci
[n,n]=size(A);
piv=[1:n];
for k=1:n-1
  [mavx,r]=max(abs(A(k:n,k)));
  q=r+k-1;
  piv([k q])=piv([q k])
  A([k q],:)=A([q k],:)
  if A(k,k)~=0
    A(k+1:n,k)=A(k+1:n,k)/A(k,k);
    A(k+1:n,k+1:n)=A(k+1:n,k+1:n)-A(k+1:n,k)*A(k,k+1:n);
    end
  end
L=eye(n,n)+tril(A,-1);
U=triu(A);
endfunction