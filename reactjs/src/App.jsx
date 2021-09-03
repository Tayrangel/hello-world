import React from 'react'
import App from './App.css'

//importação dos componentes
import Primeiro from './components/Primeiro'
import ComParam from './components/ComParam'
import ComFilhos from './components/ComFilhos'
import Card from './components/Card'
import Repeticao from './components/Repeticao'
import Condicional from './components/Condicional'
import CondicionaComIf from './components/CondicionaComIf'
import Pai from './components/Pai'
import Super from './components/Super'
import Input from './components/Input'
import Contador from './Contador/Contador'

export default (props) => (
    <div className="App">
        <h1>Fundamentos React</h1>

        <div className="Cards">
            <Card titulo="#10 - Contador" color="#32aabe">
                <Contador passo={10} valor={20}/>
            </Card>
            <Card titulo="#09 - Input" color="#32aabe">
                <Input />
            </Card>
            <Card titulo="#08 - Comunicação indireta" color="#2d98a9">
                <Super />
            </Card>
            <Card titulo="#07 - Comunicação direta" color="#278695">
                <Pai sobrenome="Rangel"/>
            </Card>
            <Card titulo="#06 - Condicional com If" color="#227481">
                <CondicionaComIf numero={11}/>
            </Card>
            <Card titulo="#05 - Condicional" color="#1d626d">
                <Condicional numero={10}/>
            </Card>
            <Card titulo="#04 - Lista de produtos" color="#175059">
                <Repeticao></Repeticao>
            </Card>
            <Card titulo="#03 - Meu primeiro card" color="#123e44">
                <ComParam titulo="Componente com parametro"/>
                <Primeiro />
            </Card>
            <Card titulo="#02 - Componente com filho" color="#123e44">
                <ComFilhos>
                    <ul>
                        <li>Filho1</li>
                        <li>Filho2</li>
                        <li>Filho3</li>
                    </ul>
                </ComFilhos>
            </Card>
            <Card titulo="#01 - Conteudo" color="#123e44">
                <Primeiro />
            </Card>
        </div>
    </div>
)
