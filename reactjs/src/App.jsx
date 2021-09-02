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

export default (props) => (
    <div className="App">
        <Card titulo="#05 - Condicional com If">
            <CondicionaComIf numero={11}/>
        </Card>
        <Card titulo="#05 - Condicional">
            <Condicional numero={10}/>
        </Card>
        <Card titulo="#04 - Lista de produtos">
            <Repeticao></Repeticao>
        </Card>
        <Card titulo="#03 - Meu primeiro card">
            <ComParam titulo="Componente com parametro"/>
            <Primeiro />
        </Card>
        <Card titulo="#02 - Componente com filho">
            <ComFilhos>
                <ul>
                    <li>Filho1</li>
                    <li>Filho2</li>
                    <li>Filho3</li>
                </ul>
            </ComFilhos>
        </Card>
        <Card titulo="#01 - Conteudo">
            <Primeiro />
        </Card>

    </div>
)
