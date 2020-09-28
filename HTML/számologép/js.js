let sc;
function init() {
    sc = document.getElementById("screen");
    console.log(sc.value);
}

function beir(adat) {
    //console.log(adat.innerText);
    let gomb = adat.innerText;
    if (gomb === 'C') {
        sc.value = '0';
    } else if (gomb === '=') {
        sc.value = eval(sc.value);
    } else {
        if (sc.value === '0') {
            sc.value = gomb;
        } else {
            sc.value += gomb;
        }
    }

}