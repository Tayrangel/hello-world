function calcular() {
    var num = document.getElementById('txtn')
    var res = document.getElementById('seltab')

    if (num.value.length == 0) {
        window.alert('[ERRO] faltam dados')
    } else {
        var nu = Number(num.value)
        var c = 1
        res.innerHTML = ''
        while (c < 11) {
            var item = document.createElement('option')
            item.text = `${nu} x ${c} = ${nu*c}`
            item.value = `res ${c}`
            res.appendChild(item)
            c++
        }  
    }
}