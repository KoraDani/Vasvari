$(document).ready(function(){
    $("select").change(function () {
        let mez = $(this).val();
        console.log(mez);
        let url = "jatekos.php?mez="+mez;
        location.href =url;
    });
});