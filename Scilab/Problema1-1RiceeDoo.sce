// Exercicio 1.1
// Ref. Rice e Doo, Applied Mathematics and Modeling for Chemical Engineers, John Wiley, New York, 1995 (pp. 17-28)

// Ver equação 1.17
// Dados do problema
Cp = 1.0; // kcal/kg/oC
R=0.01; // m
v0=1.0; // m/s
ro=1000.; // kg/m3
mi=0.001; // kg/m/s
k=1.43e-4; // kcal/s/m/K
// Temperaturas
T0=22.0; // oC
Tinf=20.0; // oC
Tw=Tinf; // oC
Ts=20.5; // oC

// Correlacao para o calculo de h (Bird et al., 1960)
D=2*R;
A=%pi*D^2/4;  // area da seccao de escoamento
Re=ro*v0*D/mi;
mprintf('\n Re = %f', Re)
Pr=Cp*mi/k;

Nu=0.026*Re^0.8*Pr^(1/3);
h=Nu*k/D;
mprintf('\n h = %f', h)
L=-v0*A*ro*Cp/(2*%pi*R*h)*log((Ts-Tw)/(T0-Tw));
mprintf('\n L = %f', L)
mprintf('\n L/D = %f', L/D)
