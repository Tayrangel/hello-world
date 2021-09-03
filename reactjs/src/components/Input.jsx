import React, {useState} from 'react'

export default props => {
    const [nome, setNome] = useState('Tay')

    return (
    <>
        <h3>{nome}</h3>
        <input type="text" value={nome} onChange={e => setNome(e.target.value)}/>
    </>
    //caso não usar o onChange, pode usar readOnly
    )
}