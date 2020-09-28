/*function tablaKeszito(){
let t = '<table>';
for (let index = 0; index < 100; index++) {
    //t.push(Math.ceil(Math.random()*100));
    if(index % 10 == 0){
        t += '<tr>';
    }
    if(index % 11 == 0){
        t+= '<td class="foatlo">'+ index + '</td>';
    } 
    else {
    if(index % 9 == 0){
        t+= '<td class="mellekatlo">'+ index + '</td>';
    }
    else{
    t+= '<td>' + index + '</td>';
    }
    }
    if(index % 10 == 9){
        t += '</tr>';
    }
    }

t += '</table>';
//document.write(t);
document.getElementById("table").innerHTML = t;
console.log(t);
}*/

function tablaKeszito() {
    let t = '<table>';
    for (let i = 0; i < 16; i++) {
        t+= '<tr>';
        let szin ="";
        //console.log(typeof(szin));
        for (let j = 0; j < 16; j++) {
            //szin += atvalt(i) + atvalt(j);
            szin += i.toString(16) + j.toString(16)+ "0";
            console.log(szin+",");
            t += '<td style="background-color: #' +szin +'"></td>';
            szin = "";
        }
        t+= '</tr>';
    }
    t +='</table>'
    document.getElementById('table').innerHTML= t;
}

function atvalt(szam) {
    if (szam > 9) {
        switch (szam) {
            case 10: return 'a'; break;
            case 11: return 'b'; break;
            case 12: return 'c'; break;
            case 13: return 'd'; break;
            case 14: return 'e'; break;
            case 15: return 'f'; break;
        }
    }else{
        return String(szam);
    }
}