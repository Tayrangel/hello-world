import React from 'react'

//Realiza a declaração do parâmetro e a interpolação através de {}
export default props =>
    <>
        <h3>{props.titulo}</h3>
        <p>{1 + 2}</p>
        <p>{Array(10).fill(0)}</p>
    </>

/*Realizar a chamada do componente sem determinar o parâmetro 
export default () =>
    <>
        <h3>Título</h3>
        <p>Parágrafo</p>
    </>
*/