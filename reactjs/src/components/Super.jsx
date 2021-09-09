import { func } from 'prop-types'
import React, { useState } from 'react'
import Sub from './Sub'

export default (props) => {

    const [texto, setTexto] = useState('Valor')
    const [num, setNum] = useState(0)

    function quandoClicar(valorGerado, texto) {
        setNum(valorGerado)
        setTexto(texto)
    }

    return (
        <div>
            <h4>{texto}: {num}</h4>
            <Sub onClicar={quandoClicar}></Sub>
        </div>
    )
}


/*Código escrito na primeira versão
import React from 'react'
import Sub from './Sub'

export default props => {

    function quandoClicar(valorGerado) {
        console.log('Ação!')
        console.log(valorGerado)
    }

    return (
    <div>
        <p>Valor</p>
        <Sub onClicar={quandoClicar}></Sub>
    </div>
    );
};*/