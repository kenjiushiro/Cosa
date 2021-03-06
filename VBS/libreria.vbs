'Funcion par aincluir otros files
Sub Include(strFile)
	Set objFSO = CreateObject("Scripting.FileSystemObject")
	Set objTextFile = objFSO.OpenTextFile(strFile, 1)
	ExecuteGlobal objTextFile.ReadAll
	objTextFile.Close
	Set objFSO = Nothing
	Set objTextFile = Nothing
End Sub


if Wscript.Arguments.count <> 0 then
    curPath = WScript.Arguments(WScript.Arguments.Count - 1)
    ' curPath = WScript.Scriptfullname
    libreriaPath = left(curPath, InStrRev(curPath, "\")) & "libreria.vbs"
    msgbox libreriaPath
end if

'Devuelven fechas con 2 cifras
mes = Right("00" & month(now),2)
dia = Right("00" & day(now),2)
hora = Right("00" & hour(now),2)
minutos = Right("00" & minute(now),2)
segundos = Right("00" & second(now),2)

'Crear hoja nueva
function CrearHoja(wb,nombre)
    Set hojaCreada = wb.Worksheets.Add
    hojaCreada.name = nombre
    set CrearHoja = hojaCreada
end function

'Ej: Call PegarArrayEnRango(arrayConData,sh.range("A1"))
Sub PegarArrayEnRango(arr,rango)
    rango.resize(UBound(arr,1),UBound(arr,2)).value = arr
end sub

'Diccionario
' Set dictDestinatarios = CreateObject("Scripting.Dictionary")


'Devuelve el numero de columna de un array de datos
function GetColumnNumberFromArray(arr,columnName)
    columnName = LCase(columnName)
    GetColumnNumberFromArray = 0
    For i = 1 To UBound(arr, 2)
        If trim(LCase(arr(1, i))) = columnName Then
            GetColumnNumberFromArray = i
            Exit For
        End If
    Next
end function

'Retorna la primer instancia de excel abierta
Function GetExcelApp()
    on error resume next
    Set GetExcelApp = GetObject(,"Excel.Application")
end function

'Retorna el objeto workbook si ya esta abierto, si no esta abierto lo abre.
Function GetWorkbook(excelPath)
    on error resume next
    Set excelApp = GetObject(,"Excel.Application")
    if err.number = 429 then
        Set excelApp = CreateObject("Excel.Application")
        err.clear
    end if
    excelApp.visible = true
    
    found = false
    if excelApp.Workbooks.count <> 0 then
        for each wb in excelApp.Workbooks
            if wb.Fullname = excelPath then
                found = true
                set GetWorkbook = wb
                exit for
            end if
        next
    end if
    if Not found then 
        set GetWorkbook = excelApp.Workbooks.Open(excelPath)
    end if
End Function


'Retorna un workbook pasandole parte del nombre
Function GetWorkbookConNombre(nombreWb)
    on error resume next
    Set excelApp = GetObject(,"Excel.Application")
    
    For Each wb In excelApp.Workbooks
        If InStr(1, Workbook.Name, nombreWb) > 0 Then
            set GetWorkbookConNombre = wb
            exit for
        End If
    Next
End Function

'cierra la instancia de excel
sub CerrarExcel()
    on error resume next
    Set excelApp = GetObject(,"Excel.Application")
    excelApp.DisplayAlerts = False
    excelApp.Quit
    err.clear
end sub

'crea una columna en una worksheet, hoja es el objeto worksheet, buscar es el nombre de referencia 
'de donde queremos pegar la columna, posicionColumnaNuevo = 0 para pegarlo a la izq, o 1 para la derecha,
'y nombre nuevo es el nombre de la columna
Sub InsertarColumna(hoja, buscar, posicionColumnaNueva, nombreNuevo)
    col = GetColumna(hoja, buscar, 1) + posicionColumnaNueva
    letra = Col_Letter(hoja,CLng(col))
    hoja.Range(letra & ":" & letra).Insert
    hoja.Range(letra & 1).Value = nombreNuevo
End sub

'agrega una columna al final
Sub AgregarColumnaAlFinal(hoja, nombreNuevo)
    letra = Col_Letter(hoja, hoja.UsedRange.Columns.Count + 1)
    hoja.Range(letra & ":" & letra).Insert
    hoja.Range(letra & 1).Value = nombreNuevo
End Sub

'retorna numero de columna de una hoja, headerRow es la fila donde esta la cabecera
Function GetColumna(hoja, nombreColumna, headerRow)
    For i = 1 To hoja.UsedRange.Columns.Count
        If hoja.Cells(headerRow, i).Value = nombreColumna Then
            GetColumna = i
            Exit for
        end if
    Next
End Function

'retorna la letra de una columna, pasandole una hoja y numero de columna
Function Col_Letter(hoja,lngCol)
    vArr = Split(hoja.Cells(1, lngCol).Address(True, False), "$")
    Col_Letter = vArr(0)
End Function

'Abre una sesion de sap o retorna el objeto si ya estaba abierta, pasandole el nombre de la conexion
Function AttachSession(connectionName)
    sessionFound = False
    Set SapGuiAuto = GetObject("SAPGUI") 
    Set SAPApp = SapGuiAuto.GetScriptingEngine
    if SAPApp.Connections.Count <> 0 then 
        For Each Connection In SAPApp.Connections
            If Connection.Description = connectionName Then
                Set AttachSession = Connection.Children(0)
                sessionFound = True
                Exit For
            End If
        Next
    End If
    If Not sessionFound Then
        Set AttachSession = SAPApp.OpenConnection(connectionName).Children(0)
    End If
End Function

'Retorna una hoja de un workbook, pasandole el nombre, es case insensitive
Function GetSheet(wb, sheetName)
    For Each sh In wb.Worksheets
        If trim(lcase(sh.Name)) =  trim(lcase(sheetName)) Then
            Set GetSheet = sh
            Exit For
        End If
    Next
End Function

'para usar excels como bases de datos, no funciona todavia :(
Sub Copy_ADO(pathOrigen, hojaOrigen, columnasACopiar, rangoDestino, filtros)
    Set conexion = CreateObject("ADODB.Connection")
    tipoFile = ""
    If InStr(1, LCase(pathOrigen), ".xlsm") Then
        tipoFile = " Macro"
    ElseIf InStr(1, LCase(pathOrigen), ".xlsx") Then
        tipoFile = " Xml"
    End If
    conexion.Open "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & pathOrigen & _
    ";Extended Properties=""Excel 12.0" & tipoFile & ";HDR=YES"";"
    If filtros <> "" Then
        filtros = " WHERE " & filtros
    End If
    query = "SELECT " & columnasACopiar & " FROM [" & hojaOrigen & "$]" & filtros
    Set rs = CreateObject("ADODB.Recordset")
    On Error Resume Next
    rs.Open query, conexion
    rangoDestino.CopyFromRecordset rs
    conexion.Close
End Sub



'para los strings con tildes
function ReemplazarTildes(stringTildes)
    stringTildes = replace(stringTildes,"á",Chr(225))
    stringTildes = replace(stringTildes,"Á",Chr(193))
    
    stringTildes = replace(stringTildes,"é",Chr(233))
    stringTildes = replace(stringTildes,"É",Chr(201))
    
    stringTildes = replace(stringTildes,"í",Chr(237))
    stringTildes = replace(stringTildes,"Í",Chr(205))
    
    stringTildes = replace(stringTildes,"ó",Chr(243))
    stringTildes = replace(stringTildes,"Ó",Chr(211))
    
    stringTildes = replace(stringTildes,"ú",Chr(250))
    stringTildes = replace(stringTildes,"Ú",Chr(218))

    stringTildes = replace(stringTildes,"°",Chr(176))
    stringTildes = replace(stringTildes,"º",Chr(186))

    ReemplazarTildes = stringTildes
end function

function Dividir(numA,numB)
    Dividir = numA/ numB

end function

'para compilar reportes
'si es el primer reporte copiado, copia los headers, si no solo la info
Sub CompilarReportes(shOrigen, shDestino)
    linea = shDestino.UsedRange.Rows.Count
    If linea = 1 Then
        arrACopiar = shOrigen.UsedRange.Value
    Else
        arrACopiar = shOrigen.UsedRange.Offset(1, 0).Value
        linea = linea + 1
    End If

    shDestino.Range("A" & linea).Resize(UBound(arrACopiar, 1), UBound(arrACopiar, 2)).Value = arrACopiar
End Sub

'para correr comandos de cmd
sub ComandoCMD(comando)
    Set oShell = WScript.CreateObject ("WScript.Shell")
    ' oShell.run ("msg %username% asdadawd")
    oShell.run (comando)
end sub