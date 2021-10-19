// Transferencia de calor aleta
// Aula 02
clear
// Modelo  Nivel 1 
// Dados do problema

hG=10.0;
hL=250;
L1=1.0;
L2=1.0;
T1=100;
T0=25;
R=0.0127;

alfa=hL*L1/hG/L2
mprintf('\n alfa = %f', alfa)

T=(T0+alfa*T1)/(1+alfa)
mprintf('\n T1 = %f', T)

// Modelo Nivel 2
k=230;
m=sqrt(2*hG/k/R);
x=[0:0.1:1];
T=T0+((T1-T0)*cosh(m*(L2-x)))/cosh(m*L2);    

scf(0)
plot(x,T)
// Calculo do fator de efetividade

eta=tanh(m*L2)/m/L2;
mprintf('\n eta = %f', eta)

// Modelo Nivel 3
xI=[-1:0.1:0];
xII=[0:0.1:1];
n=sqrt(2*hL/k/R);

A=-(T1-T0)/(cosh(n*L1)+n/m*sinh(n*L1)/sinh(m*L2)*cosh(m*L2));
B=(T1-T0)/(cosh(m*L2)+m/n*sinh(m*L2)/sinh(n*L1)*cosh(n*L1));

TI=T1+A*cosh(n*(xI+L1));
TII=T0+B*cosh(m*(L2-xII));

scf(2)
a=get("current_axes");//get the handle of the newly created axes
a.data_bounds=[-1,0;0,100];
plot(xI,TI)

scf(3)
a=get("current_axes");//get the handle of the newly created axes
a.data_bounds=[0,1;0,100];
plot(xII,TII)

mprintf('\n m/n = %f', m/n)
