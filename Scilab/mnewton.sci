function [xres, fxres, niter]=mnewton(x,tol,nmax)
// Metodo de Newton

// Uses de function fun.sci
getd

h=0.001;

x1=[x, x+h];
fx1=fun(x1);
d=fx1(1)*h/(fx1(2)-fx1(1));

niter=0;

while (abs(d)>tol) & (niter<=nmax)
    xn=x-d;
    x1=[xn, xn+h];
    fx1=fun(x1);
    d=fx1(1)*h/(fx1(2)-fx1(1));;
    niter=niter+1;
    x=xn;
end

xres=x; fxres=fun(xres);

endfunction
