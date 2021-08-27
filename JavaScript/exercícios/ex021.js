let num = [4, 6, 8, 12, 16, 22, 35, 40]

/*for (let pos = 0; pos < num.length; pos++) {
    console.log(num[pos])
}*/

for (let pos in num) {
    console.log(`A posição ${pos} tem o valor ${num[pos]}`)
}