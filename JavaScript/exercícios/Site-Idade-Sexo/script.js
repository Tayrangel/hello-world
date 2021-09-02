function verificar() {
    var data = new Date()
    var ano = data.getFullYear()
    var fano = document.getElementById('txtano')
    var res = document.querySelector('div#res')
    if (fano.value.length == 0 || Number(fano.value) > ano) {
        window.alert('[Erro] Verifiue os dados e tente novamente!')
    } else {
        var fsex = document.getElementsByName('radsex')
        var idade = ano - Number(fano.value)
        var genero = ''
        var img = document.createElement('img')
        img.setAttribute('id', 'foto')
        if (fsex[0].checked) {
            genero = 'Homem'
            if (idade >= 0 && idade < 10) {
                //Criança
                img.setAttribute('src', 'imagens/meninobebe.png')
            } else if (idade < 21) {
                //Jovem
                img.setAttribute('src', 'imagens/meninojovem.png')
            } else if (idade < 50) {
                //Adulto
                img.setAttribute('src', 'imagens/meninoadulto.png')
            } else {
                //Idoso
                img.setAttribute('src', 'imagens/meninoidoso.png')
            }
        } else if (fsex[1].checked) {
            genero = 'Mulher'
            if (idade >= 0 && idade < 10) {
                //Criança
                img.setAttribute('src', 'imagens/meninabebe.png')
            } else if (idade < 21) {
                //Jovem
                img.setAttribute('src', 'imagens/meninajovem.png')
            } else if (idade < 50) {
                //Adulta
                img.setAttribute('src', 'imagens/meninaadulta.png')
            } else {
                //Idosa
                img.setAttribute('src', 'imagens/meninaidosa.png')
            }
        }
        res.innerHTML = `Detectamos ${genero} com ${idade}`
        res.appendChild(img)
    }
}