function fx = funcx(x)
// Calcula o vetor de funções f(x), onde f(x[solução])=0 

  fx = zeros(N,1);   // dimensionando fx
  
  fx(1) = F/V(1)*x(1) + kc*x(1)^alfa - F*C0/V(1);
  for i=2:N
    fx(i) = F/V(i)*x(i) + kc*x(i)^alfa - F*x(i-1)/V(i) ;
  end
endfunction
