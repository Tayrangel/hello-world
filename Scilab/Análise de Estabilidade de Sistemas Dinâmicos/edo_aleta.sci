function [dx]=edo_aleta(tau,theta)

global F delta_x kapa n

// Equacoes Diferenciais Ordinarias (devem ser inseridas nesta funcao)

dtheta1=0;
dtheta2=F*((theta(1)-2.0*theta(2)+theta(3))/delta_x^2)-kapa*theta(2);
dtheta3=F*((theta(2)-2.0*theta(3)+theta(4))/delta_x^2)-kapa*theta(3);
dtheta4=F*((theta(3)-2.0*theta(4)+theta(5))/delta_x^2)-kapa*theta(4);
dtheta5=F*((2.0*theta(4)-2.0*theta(5))/delta_x^2)-kapa*theta(5)

dx=[dtheta1; dtheta2; dtheta3; dtheta4; dtheta5];

endfunction
