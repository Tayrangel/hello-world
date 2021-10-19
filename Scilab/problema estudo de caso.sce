// Problema Estudo de caso: um problema fenomenológico a parâmetros concentrados
--> F=2; Ca0=1; V1=1; V2=2; V3=4; K=1;

--> A=[F/V1+K 0 0; F/V2 F/V2+K 0; 0 -F/V3 F/V3+K]
 A  = 

   3.   0.    0. 
   1.   2.    0. 
   0.  -0.5   1.5


--> b=[F*Ca0/V1 0 0]
 b  = 

   2.   0.   0.


--> getd

--> [x]=eliminagauss(A,b)
at line    20 of function eliminagauss ( C:\Users\tayha\Documents\Mestrado - UFSCar\Métodos matemáticos e computacionais aplicados a engenharia química\eliminagauss.sci line 20 )

inconsistent row/column dimensions

--> [x]=eliminagauss(A,b')
 x  = 

   0.6666667
  -0.3333333
  -0.1111111


--> A=[F/V1+K 0 0; -F/V2 F/V2+K 0; 0 -F/V3 F/V3+K]
 A  = 

   3.   0.    0. 
  -1.   2.    0. 
   0.  -0.5   1.5


--> [x]=eliminagauss(A,b')
 x  = 

   0.6666667
   0.3333333
   0.1111111
