'Funcion para incluir la libreria
Sub Include(strFile)
	Set objFSO = CreateObject("Scripting.FileSystemObject")
	Set objTextFile = objFSO.OpenTextFile(strFile, 1)
	msgbox strFile
	ExecuteGlobal objTextFile.ReadAll
	objTextFile.Close
	Set objFSO = Nothing
	Set objTextFile = Nothing
End Sub
'Si esta siendo llamado desde automation, levanto la ruta de la libreria desde el parametro de AA
if Wscript.Arguments.count <> 0 then
    curPath = WScript.Arguments(WScript.Arguments.Count - 1)
    libreriaPath = left(curPath, InStrRev(curPath, "\")) & "libreria.vbs"
else
'Si el script esta siendo corrido desde wscript, levanto la ruta de la libreria al mismo nivel que el script
	libreriaPath = left(wscript.scriptfullname, InStrRev(wscript.scriptfullname, "\")) & "libreria.vbs"
end if
'Incluye la libreria
call include(libreriaPath)
'Retorno el resultado de la funcion Main
WScript.StdOut.Write Main()

Function Main()
	if WScript.arguments.Count > 0 then 
		'Seteo de variables si el script esta siendo llamado por AA
		numA = WScript.Arguments(0)
		numB = WScript.Arguments(1)
	else
		'Seteo de variables si el scrpit esta siendo corrido con wscript
		numA = 40
		numB = 48
	end if 

	'desarrollo
	resultado = Dividir(numA,numB)
	msgbox resultado

	'fin desarrollo

	'Si hubo un error retorno la descripcion del error, si no retorna el valor que corresponda
	if err.number <> 0 then
    	Main = err.description
		'Main = "error"
		err.clear
	else
		Main = resultado
	end if
End Function