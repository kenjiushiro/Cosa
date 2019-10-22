// document.addEventListener("load",CargarBots);
document.addEventListener("load",AgregarBot);

function CargarBots()
{
    AgregarBot("SUGUS","3.5");
    AgregarBot("Cabsha","1.2");
}

function AgregarBot()
{
    alert("asd");
    var bots={
        "bots":[
          {"botName":"SUGUS", "botVersion":"3.6.5"},
          {"botName":"Cabsha", "botVersion":"1.2"},
          {"botName":"Marroc", "botVersion":"1.6"}
        ]
    }
    var p = document.getElementById("bots");
    bots.innerText = JSON.stringify(bots);    
}