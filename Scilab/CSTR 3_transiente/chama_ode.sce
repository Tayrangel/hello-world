clear
getd;
// Use function modelo1.sci
// A funcao modelo1.sci contem o sistema de EDOs a ser integrado 

t0=0;  
h=0.1;
tn=5.0;
t=[t0:h:tn];     // Vetor da variavel independente... //t0 é o número inicial, h o passo que será realizado o programa e tn o tempo final. Indo de t0 a tn de h em h.
y0=[0.0; 0.0; 0.0];   // Vetor de condicoes iniciais... //Vetores do tempo inicial, condições iniciais, onde terá o y1 e y2 no tempo 0.

// Chamada do pacote ode para integracao do sistema de EDOs
y=ode("rk",y0,t0,t,modelo1);       //A EDO pode ser usada para o método de integração que interessa utilizar, no caso "rk = runge kutta", porém caso não seja utilizado, o pacote ODE irá chamar o método mais conveniente para a resolução do problema. Modelo 1 é a function usada para utilizar na EDO

// Apresentando a solucao na forma grafica
clf(); //Limpar a figura do plot
subplot(3,1,1) //Fazer o plot dos gráfico, porém tem a variável y1 e y2, para deixar organizado como 2 linhas e 1 coluna fica o subplot 1 (2-linha,1-coluna,1-é a variável a ser plotada)
plot(t,y(1,:),'k:') //Plota o gráfico da variável eixo t vs eixo y(1) em vários tempos, por isso inserir os :
xtitle("Concentração CA1 em funcao do tempo")
subplot(3,1,2)
plot(t,y(2,:),'k:')
xtitle("Concentração CA2 em funcao do tempo")
subplot(3,1,3)
plot(t,y(2,:),'k:')
xtitle("Concentração CA3 em funcao do tempo")
