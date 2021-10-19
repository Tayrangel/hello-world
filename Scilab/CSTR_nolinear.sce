// N reatores CSTR em Série com reação de ordem diferente de 1
//
// Use function funcx.sci  e eliminagauss.sci

clear // limpa memória do scilab
clc  // limpa a tela da janela de comando

global C0 kc alfa F V N
getd;

// Parâmetros do método numérico:
tolf = 1.0d-6;  //tolerância na função [mol/tempo]
tolx = 1.0d-6;  // tolerância na variação de x [mol/volume]
Itmax = 100; // número máximo de iterações

// Parâmetros do processo (sistema)
N = 3; // número de reatores
kc = 0.7d0; // constante cinética [mol^(1-alfa)/volume^(1-alfa)/tempo]
alfa = 1.5d0; // ordem de reação
C0 = 1.0d0; // concentração de entrada no reator 1 [mol/volume]
F = 1.d0;  // vazão volumétrica [volume/tempo]
V = [1.0 2.0 4.0]'; // volume

x  [0.8 0.6 0.3]'; // concentação nos reatores - chute inicial=

[xres, fxres, niter]=Mnewton_mv (x, tolf, tolx, Itmax)

// imprindo solução aproximada obtida
disp('solução')
xres
// imprimindo o valor da função calculada na solução obtida
disp('checando função')
fxres
