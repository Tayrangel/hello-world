function [dy]=modelo1(t,y)

// Equacoes Diferenciais Ordinarias (devem ser inseridas nesta funcao)

//Usar as variáveis diretamente na function ou coloca-las no script sce e depois usar global na function
Ca0=1.0;
F=2.0;
V(1)=1.0; //Obsrve que o uso de um vetor V para o volume: V(1), V(2)
V(2)=2.0;
V(3)=4.0;
k=1;

dy(1)=F/V(1)*(Ca0-y(1))-k*y(1);
dy(2)=F/V(2)*(y(1)-y(2))-k*y(2);
dy(3)=F/V(3)*(y(2)-y(3))-k*y(3);

endfunction
