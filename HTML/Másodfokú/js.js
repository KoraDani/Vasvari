let a;
let b;
let c;
let ax;
let bx;
let cx;
function be() {
    ax = document.getElementById("a");
    bx = document.getElementById("b");
    cx = document.getElementById("c");
    a = ax.value;
    b = bx.value;
    c = cx.value;
}

function kiszamol() {
    let d1 = (b * b);
    let d2 = (4 * a * c);
    let d3 = d1-d2;
    console.log("diszkrimináns "+d1);
    if (d3 < 0) {
        console.log("hiba")
    }
    if (d3 == 0) {
        var r = (-b) / (2 * a);
        console.log("egy megoldás")
    }
    if (d3 > 0) {
        var r1 = (-b + Math.sqrt(d3)) / (2 * a);
        var r2 = (-b - Math.sqrt(d3)) / (2 * a);
        console.log("két megoldás"+" "+ r1+ " " + r2)
    }
}

