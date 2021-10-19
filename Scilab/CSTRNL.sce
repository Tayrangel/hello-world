// Script que resolve equação algébrica não linear empregando o método de Newton Raphson
// Exemplo do reator CSTR com reação de ordem 1,5

clear
clc
getd

//Dados do problema

F0=1.0;
V1=1.0;
Ca0=1.0;
k=1.0;
n=1.5;
x=0.5; //Chute para a saída do reator (Ca1)

//Dados para o método numérico
tol=0.00001;
nmax=100;
ninter=500;

[xres, fxres, niter]=mnewton(x,tol,nmax)

printf('\n xres=%f', xres);
printf('\n fxres=%f', fxres);
