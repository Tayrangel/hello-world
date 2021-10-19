//Estudo de caso: Transferência de calor em uma tubulação

//Thiago de Melo Augusto
//Data: 23/04/18

clear
getd

//Dados do problema
d1=0.020 //diâmetro interno (m)
d2=0.025 //diâmetro externo (m)
d3=0.105 //diâmetro do isolante ((d3-d2)/2=40)(m)
hi=1700 //coeficiente de troca de calor convectivo do vapor (W/m2K)
h0=30 //coeficiente de troca de calor convectivo do lado externo(W/m2K)
ks=43 //condutividade térmica média do metal(W/mK)
ki=0.064 //condutividade térmica média do isolante (W/mK)
Tar=298 //temperatura do ar (K)
Ts=403 //temperatura do vapor saturado (K)

//Realizando o Balanço de Energia e obtendo-se uma equação algébrica não linear

//Ìdentificação dos componentes da matriz A  

A11=-(((2*ks)/log(d2/d1))+hi*d1);
A12=(2*ks)/(log(d2/d1));
A13=0;
A21=ks/log(d2/d1);
A22=-((ks/log(d2/d1))+(ki/log(d3/d2)));
A23=ki/log(d3/d2);
A31=0;
A32=((2*ki)/log(d3/d2));
A33=-(((2*ki)/log(d3/d2))+h0*d3);

//Identificando os termos do coeficiente b

b1=-hi*d1*Ts;
b2=0;
b3=-h0*d3*Tar;

//Determinando matriz A e os coeficientes lineares do sistema Ax=b

A=[A11 A12 A13;A21 A22 A23;A31 A32 A33];
b=[b1 b2 b3]';


[x]=eliminagauss(A,b)

printf('Temperatura interna do lado interno da parede\nT1= \n%f\n',x(1));
printf('Temperatura interna do lado externo da parede\nT2= \n%f\n',x(2));
printf('Temperatura interna do lado externo do isolante\nT3= \n%f\n',x(3));
