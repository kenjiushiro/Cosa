if WScript.Arguments.count > 0 then
	hora = Clng(Wscript.arguments(0))
else
	hora = 0
end if

Dim objWMIService, colProcess
Dim strComputer, strList, p
strComputer = "."
Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
Set colProcess = objWMIService.ExecQuery("Select * from Win32_Process Where Name Like 'wscript.exe'")
if colProcess.count < 2 then
    Set wsc = CreateObject("WScript.Shell")
    hm = Minute(Now()) + 100 * Hour(Now())
	
	if hora = 0 then
		hora = clng(inputbox("? (HHMM)","?","1800"))
	end if

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
