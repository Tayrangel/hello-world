const main = (params) => {
    function randomTxt() {
        var c = 'abcdefdhijklmnopqrstuvwxyz'
        var ran = ''
        var palindrome = 0
        for (var i=0; i < 10000; i++) {
            for (var j=0; j < 5; j++) {
                var randomNumber = Math.floor(Math.random() * letras.length);
                ran = ran + c.substring(randomNumber, randomNumber + 1);
            }
            if (ran == ran.split('').reverse().join('')) {
                palindrome++;
            }
        }
        console.log("The number of words that are palindromes is" + palindrome)
    }
}