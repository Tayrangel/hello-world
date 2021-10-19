function [u]=tridag(a,b,c,r,n)

// Resolve para um vetor u de dimensao n o conjunto de equacoes lineares
// 
//  
//

if (b(1) == 0) abort
end

bet=b(1);
u(1)=r(1)/bet;
for j=2:n,
  gam(j)=c(j-1)/bet;
  bet=b(j)-a(j)*gam(j);
  if (bet == 0) abort
  end
  u(j)=(r(j)-a(j)*u(j-1))/bet;
end

for j=n-1:-1:1,
  u(j)=u(j)-gam(j+1)*u(j+1)
end

endfunction
