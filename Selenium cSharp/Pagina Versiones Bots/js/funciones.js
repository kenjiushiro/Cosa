// document.addEventListener("load",CargarBots);
window.onload = AgregarBot;

function CargarBots()
{
    AgregarBot("SUGUS","3.5");
    AgregarBot("Cabsha","1.2");
}

function AgregarBot()
{
    var pelemento = document.createElement("p");
    var ptexto = document.createTextNode("LALALALA");
    pelemento.appendChild(ptexto);
    pelemento.id = "Lala";
    document.getElementById("ancla").append(pelemento);

}