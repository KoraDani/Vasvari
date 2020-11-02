function fajlbolOlvas(){
    let reader = new FileReader();
    reader.readAsText('typer.txt');
    reader.onload = function(){
        console.log(reader.result);
    }

}