let num = [5, 1, 2, 3, 4]
num.push(6) //acrescentou um novo elemento
num.sort() //coloca em ordem crescente
console.log(num)
console.log(`Nosso vetor tem ${num.length} elementos`) //númeo de elementos do meu vetor
console.log(`O valor do primeiro elemento do vetor é ${num[0]}`) //primeiro valor do vetor


let pos = num.indexOf(8) //procura o valor e retorna o seu índice
if (pos == -1) {
    console.log('Valor não encontrado!')
} else {
console.log(`A posição do valor 3 é ${pos}`) 
}