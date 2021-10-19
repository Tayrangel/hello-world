clear 

getd

//Dados do problema
//Aleta - alumínio de 0.5"
np=101; //np-número de pontos utilizados na malha
L=1.0; //comprimento da aleta
h=12.0; //coeficiente de troca térmica por convecção
T0=77;//temperatura da base da aleta alumínio 0.5//usou 77 a pedido do professor, por ser a primeira temperatura da tabela experimental
T02=63.0; //temperatura da base da aleta aço 0.5
T03=72.0; //temperatura da base da aleta aço 1.0
Tinf=22;//temperatura do ambiente
d=0.0127; //diametro da aleta 0.5"
d2=0.0254; //diametro da aleta 1.0"
kal=229; //coeficiente de troca térmica por condução
kac=17.3;
m2=4*h/(kal*d);
m22=4*h/(kac*d);
m23=4*h/(kac*d2);

//Gerando pontos internos da malha - aleta alumínio 0.5
deltax=L/(np-1);

for i=1:np,
   x(i)=(i-1)*deltax;
end

kapa=m2*deltax^2;
//Gerando pontos internos da malha - aleta aço 0.5
deltax2=L/(np-1);

for i=1:np,
   x2(i)=(i-1)*deltax2;
end

kapa2=m22*deltax2^2;
//Gerando pontos internos da malha - aleta aço 1.0
deltax3=L/(np-1);

for i=1:np,
   x3(i)=(i-1)*deltax3;
end

kapa3=m23*deltax3^2;

//montagem do coeficientes relativos aos pontos internos da matriz tridiagonal - aleta alumínio 0.5

a(1)=0.0;
b(1)=1.0;
c(1)=0.0;
r(1)=T0;

for i=2:np-1;
    a(i)=1.0;
    b(i)=-(2+kapa);
    c(i)=1.0;
    r(i)=-kapa*Tinf;
end

a(np)=2.0;
b(np)=-(2+kapa);
c(np)=0.0;
r(np)=-kapa*Tinf;

[u]=tridag(a,b,c,r,np);

m=sqrt(m2);

for i=1:np;
    y(i)=(T0-Tinf)*(cosh(m*(L-x(i))))/cosh(m*L)+Tinf;
end

//montagem do coeficientes relativos aos pontos internos da matriz tridiagonal - aleta aço 0.5
a2(1)=0.0;
b2(1)=1.0;
c2(1)=0.0;
r2(1)=T0;

for i=2:np-1;
    a2(i)=1.0;
    b2(i)=-(2+kapa2);
    c2(i)=1.0;
    r2(i)=-kapa2*Tinf;
end

a2(np)=2.0;
b2(np)=-(2+kapa2);
c2(np)=0.0;
r2(np)=-kapa2*Tinf;

[u]=tridag(a2,b2,c2,r2,np);

m=sqrt(m2);

for i=1:np;
    y(i)=(T0-Tinf)*(cosh(m*(L-x(i))))/cosh(m*L)+Tinf;
end
//Dados experimentais

xexp=[0 0.03 0.078 0.149 0.224 0.299 0.449 0.599 0.749 0.899];
yexp=[77 71 61 48 41 37 31 27 25 24];

//Impressao dos resultados (gráficos)

clf()

plot(x,u,'b',x,y,'r',xexp,yexp,'x')

soma=0;
for i=2:np;
    soma=soma+((u(i)+u(i-1))*(x(i)-x(i-1)))/2;
end
integral1=(soma)-(Tinf*L)
integral2=(integral1*%pi*d*h)
derivada=((%pi*(d^2*(-1)*k)/4)*(u(2)-u(1)))/(x(2)-x(1))
resposta=derivada-integral2
disp(resposta)
