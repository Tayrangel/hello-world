//Esvaziamento de um tanque cilindrico
//atribuindo valores para variaveis

h0=100;
d=0.8;
D=12;
g=980;

as=(%pi*d^2)/4;
Ab=(%pi*D^2)/4;

t=[1:1:101]

h=((2*sqrt(h0)-sqrt(2*g)*(as/Ab)*t)/2)^2)

plot(t,h)
