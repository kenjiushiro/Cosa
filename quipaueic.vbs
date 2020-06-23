Dim objWMIService, colProcess
Dim strComputer, strList, p
strComputer = "."
Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
Set colProcess = objWMIService.ExecQuery("Select * from Win32_Process Where Name Like 'wscript.exe'")
if colProcess.count < 2 then
    Set wsc = CreateObject("WScript.Shell")
    hm = Minute(Now()) + 100 * Hour(Now())

    hora = clng(inputbox("? (HHMM)","?","1800"))

    Do While hm < hora
        WScript.Sleep (60 * 1000)
        wsc.Sendkeys ("{SCROLLLOCK 2}")
        hm = Minute(Now()) + 100 * Hour(Now())
    loop
    msgbox "off :("
else
    msgbox "off :("
    for each p in colProcess
        p.Terminate
    next 
end if
