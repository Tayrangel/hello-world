function [dx]=modelo1(t,y)

// Equacoes Diferenciais Ordinarias (devem ser inseridas nesta funcao)

dy1=-500.5*y(1)+499.5*y(2);
dy2=499.5*y(1)-500.5*y(2);

dx=[dy1; dy2];

endfunction
