function contar() {
    let inicio = document.getElementById('txti')
    let fim = document.getElementById('txtf')
    let passo = document.getElementById('txtp')
    let res = document.getElementById('res')

    if (inicio.value.length == 0 || fim.value.length == 0 || passo.value.length == 0) {
        window.alert('[ERRO] faltam dados')
    } else {
        res.innerHTML = 'Contando: '
        let ini = Number(inicio.value)
        let fi = Number(fim.value)
        let pa = Number(passo.value)
        if (pa <= 0) {
            window.alert('Passo inválido! Considerando o valor do Passo = 1')
            pa = 1
        }

        if (ini < fi) { //contagem crescente
        for(let c = ini; c <= fi; c += pa) {
            res.innerHTML += `${c} \u{1F449}`
        }
    } else { //contagem decrescente 
        for(let c = ini; c >= fi; c -= pa) {
            res.innerHTML += `${c} \u{1F449}`
        }
    }
        res.innerHTML += `\u{1F3C1}`
    }
}