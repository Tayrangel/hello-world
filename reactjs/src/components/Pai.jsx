import React from 'react'
import Filho from './Filho'

export default props =>
    <div>
    <Filho {...props}>Filho 1</Filho>
    <Filho sobrenome={props.sobrenome}>Filho 2</Filho>
    <Filho sobrenome="Maroni">Filho 3</Filho>
    </div>