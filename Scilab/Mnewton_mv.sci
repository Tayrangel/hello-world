function [xres, fxres, niter]=Mnewton_mv (x, tolf, tolx, Itmax)
    ok = 0;     // variavel que indica criterio de parada do while
    k = 0;      // contador de iteracoes
    h = 1.0d-4; // incremento usado no calculo da derivada numerica

    Jac = zeros(N,N); // dimensionando a matriz Jacobiana 
 
    while ok == 0 
       k=k+1;
       fx = funcx(x);    //calcula o vetor fx
       if  norm(fx,'inf') <= tolf then  // checando convergência em f(x)
         ok = 1;
         disp('fx <=tolf');
       else
    // Calcula a matriz Jacobiana
          for j=1:N
              xj = x(j); // guardando o valor de x(j)
              x(j) = x(j)+h; //incrementando o x(j) em h 
              fxh = funcx(x);
              Jac(:,j)=(fxh-fx)/h;
              x(j) = xj;
           end
       [y]=eliminagauss(Jac,-fx);
        x = y + x; //x[k+1]
       if norm(y,'inf') <= tolx then  // checando convergência em x
          ok = 2;
          disp('y = delta(x) <= tolx');
       elseif k >= Itmax then  // checando número de iterações
          ok = 3;
          disp('k>=Itmax');
       end
   end
end
niter=k;
xres=x;
fxres = funcx(xres);
endfunction
