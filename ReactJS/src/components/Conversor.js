import React, { Component } from "react"
import './Conversor.css'

export default class Conversor extends Component {
    //O construtor tem as props, que possibulitam acessar os atributos declarados no componente (em App.JS), que são no caso a moedaA e moedaB
    constructor(props) {
        super(props)

        //Para armazenar valores nos atributos usa
        this.state = {
            moedaA_valor: "",
            moedaB_valor: 0,
        }

        //toda função tem o método bind, assim consegue receber o objeto
        this.converter = this.converter.bind(this)
    }

    //método de conversão
    converter() {
        let de_para = `${this.props.moedaA}_${this.props.moedaB}`
        let url = `https://free.currconv.com/api/v7/convert?q=${de_para}&compact=ultra&apiKey=8c732514efc911892072`

        fetch(url)
        .then(res=> {
            return res.json()
        })
        .then(json=>{
            let cotacao = json [de_para]
            let moedaB_valor = (parseFloat(this.state.moedaA_valor) * cotacao).toFixed(2)
            this.setState({moedaB_valor})
        })
    }

    render() {
        return (
            /*Após adicionar o construtor, o qual receber as props(propriedades), pode retorná-las dentro de {}os atributos declarados*/
            <div className="conversor">
                <h2>{this.props.moedaA} para {this.props.moedaB}</h2>
                <input type="text" onChange={(event) => {this.setState({moedaA_valor: event.target.value})}}></input>
                <input type="button" value="Converter" onClick={this.converter}></input>
                <h2>Valor convertido {this.state.moedaB_valor}</h2>
            </div>
        )
    }
}