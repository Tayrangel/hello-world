Exercício 1.1

















D=2*R;
A=%pi*D^2/4;
Re=ro*v0*D/mi;
mprintf('\n Re = %f', Re)
Pr=Cp*mi/k;

Nu=0.026*Re^0.8*Pr^(1/3);
h=Nu*k/D;
mprintf('\n h = %f', h)
L=-v0*A*ro*Cp/(2*%pi*R*h)*log((Ts-Tw)/(T0-Tw));
mprintf('\n L/D = %f', L/D)
