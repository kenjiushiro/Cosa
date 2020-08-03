VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "ClsTabla"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Private tabla As ListObject
Private Const className As String = "ClsTabla"
Private currentRow As Long
Private infiniteLoopWarning As Long

Private columnIndexesDict As Scripting.Dictionary

Public Enum ComparationOperator
    Equals
    NotEqual
    Greater
    GreaterOrEqual
    LessThan
    LessThanOrEqual
    IsLike
End Enum
Private Sub Class_Initialize()
    infiniteLoopWarning = 0
    MoveToTop
End Sub
Public Sub MoveToTop()
    currentRow = 1
End Sub
Public Sub MoveToBottom()
    currentRow = Me.RowsCount
End Sub
Public Property Get tableName() As String
    tableName = tabla.name
End Property
Public Property Get TableSheet() As Worksheet
    Set TableSheet = tabla.Parent
End Property
Public Property Get TableWorkbook() As Workbook
    Set TableWorkbook = tabla.Parent.Parent
End Property
Public Sub GetTableFromSheet(sh As Worksheet)
    Dim tablaAux As ListObject
    
End Function
Public Sub CreateTableFromRange(tableRange As Range, tableName As String)
    Set tabla = tableRange.Parent.ListObjects.Add(Source:=tableRange, xllistobjecthasheaders:=xlYes)
    tabla.name = tableName
End Sub
Public Function TableExists(tableName As String, Optional wb As Variant) As Boolean
    
    If IsMissing(wb) Then
        Set wb = ThisWorkbook
    End If
    
    Dim sh As Worksheet
    Dim tablaAux As ListObject
    
    For Each sh In wb.Worksheets
        On Error Resume Next
        Set tablaAux = sh.ListObjects(tableName)
        
        If Not tablaAux Is Nothing Then
            TableExists = True
            Exit For
        End If
    Next sh
End Function
Public Sub ConvertTableToRange()
    Dim auxRange As Range
    
    If tabla Is Nothing Then
        Err.Raise 999, className & ".AddColumn", "First initialize the table (Call GetTable)"
    End If
    Set auxRange = tabla.Range
    tabla.Unlist
    Set tabla = Nothing
    auxRange.ClearFormats
    
End Sub
Public Sub GetTable(tableName As String, Optional wb As Variant)
    If IsMissing(wb) Then
        Set wb = ThisWorkbook
    End If
    Dim sh As Worksheet
    Dim tablaAux As ListObject
    
    For Each sh In wb.Worksheets
        On Error Resume Next
        Set tablaAux = sh.ListObjects(tableName)
        If Not tablaAux Is Nothing Then
            Set tabla = tablaAux
            Exit For
        End If
    Next sh
    On Error GoTo 0
    

    If tabla Is Nothing Then
        Err.Raise 999, className & ".GetTable", "Table doesn't exist in " & wb.name & " workbook"
    End If
    
    SetColumnIndexesDict
End Sub
Public Sub AddColumn(columnName As String, Optional afterColumn As Variant, Optional beforeColumn As Variant)
    If tabla Is Nothing Then
        Err.Raise 999, className & ".AddColumn", "First initialize the table (Call GetTable)"
    End If
    If Not ColumnExists(columnName) Then
        Dim columnaNueva As ListColumn
        If IsMissing(afterColumn) And IsMissing(beforeColumn) Then
            Set columnaNueva = tabla.ListColumns.Add
        ElseIf Not IsMissing(afterColumn) Then
            Set columnaNueva = tabla.ListColumns.Add
        ElseIf Not IsMissing(afterColumn) Then
            Set columnaNueva = tabla.ListColumns.Add
        
        End If
        columnaNueva.name = columnName
        SetColumnIndexesDict
    Else
        Err.Raise 999, className & ".AddColumn", "Column " & columnName & " already exists"
    End If
End Sub
Public Sub DeleteColumn(columnName As String)
    If tabla Is Nothing Then
        Err.Raise 999, className & ".DeleteColumn", "First initialize the table (Call GetTable)"
    End If
    If ColumnExists(columnName) Then
        Dim columna As ListColumn
        Set columna = tabla.ListColumns(columnName)
        columna.Delete
    Else
        Err.Raise 999, className & ".DeleteColumn", "Column " & columnName & " does not exist"
    End If
End Sub
Public Sub DeleteRow()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".DeleteRow", "First initialize the table (Call GetTable)"
    End If
    Dim linea As ListRow
    Set linea = tabla.ListRows(currentRow)
    linea.Delete
End Sub
Private Function ColumnExists(columnName As String)
    Dim columna As ListColumn
    On Error Resume Next
    Set columna = tabla.ListColumns(columnName)
    ColumnExists = Err.Number = 0
    
End Function
Private Sub SetColumnIndexesDict()

    Dim columna As ListColumn
    Set columnIndexesDict = New Scripting.Dictionary
    Dim col_name As String
    Dim col_index As Long
    
    For Each columna In tabla.ListColumns
        col_name = columna.name
        col_index = columna.index
        columnIndexesDict(col_name) = col_index
        
    Next columna
End Sub

Public Sub ShowTotals()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".ShowTotals", "First initialize the table (Call GetTable)"
    End If
    tabla.ShowTotals = True
End Sub
Public Sub HideTotals()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".HideTotals", "First initialize the table (Call GetTable)"
    End If
    tabla.ShowTotals = True
End Sub
Public Sub DeleteEmptyRows()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".DeleteEmptyRows", "First initialize the table (Call GetTable)"
    End If
    Dim linea As ListRow
    Dim i As Long
    
    For i = tabla.ListRows.Count To 1 Step -1
        Set linea = tabla.ListRows(i)
        If WorksheetFunction.CountA(linea.Range) = 0 Then
            linea.Delete
        End If
    Next i
End Sub
Public Sub DeleteAllRows()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".DeleteAllRows", "First initialize the table (Call GetTable)"
    End If
    On Error Resume Next
    tabla.DataBodyRange.Clear
    tabla.Resize Union(tabla.HeaderRowRange, tabla.HeaderRowRange.Offset(1))
End Sub
Public Function ThisRow(Optional headerName As Variant) As Range
    If tabla Is Nothing Then
        Err.Raise 999, className & ".ThisRow", "First initialize the table (Call GetTable)"
    End If
    infiniteLoopWarning = infiniteLoopWarning + 1
    If IsMissing(headerName) Then
        Set ThisRow = tabla.ListRows(currentRow).Range
    Else
        Dim col As Long
        col = tabla.ListColumns(headerName).index
        Set ThisRow = tabla.ListRows(currentRow).Range(1, col)
    End If

    If infiniteLoopWarning > 1000 Then
        Err.Raise 999, className & ".ThisRow", "Infinite loop detected"
    End If
End Function
Public Sub MoveToNewLine()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".MoveToNewLine", "First initialize the table (Call GetTable)"
    End If
    Dim linea As ListRow
    Set linea = tabla.ListRows.Add
    currentRow = linea.index
End Sub
Public Sub UpdateValue(columnName As String, columnValue As Variant)
    If tabla Is Nothing Then
        Err.Raise 999, className & ".UpdateValue", "First initialize the table (Call GetTable)"
    End If
    Dim linea As ListRow
    Dim col_index As Long
    col_index = columnIndexesDict(columnName)
    Set linea = tabla.ListRows(currentRow)
    
    linea.Range(1, col_index).value = columnValue
End Sub
Public Sub MoveNext()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".MoveNext", "First initialize the table (Call GetTable)"
    End If
    infiniteLoopWarning = 0
    currentRow = currentRow + 1
End Sub
Public Sub MovePrevious()
    If tabla Is Nothing Then
        Err.Raise 999, className & ".MovePrevious", "First initialize the table (Call GetTable)"
    End If
    infiniteLoopWarning = 0
    currentRow = currentRow - 1
End Sub
Public Function EOT() As Boolean
    If tabla Is Nothing Then
        Err.Raise 999, className & ".EOT", "First initialize the table (Call GetTable)"
    End If
    EOT = currentRow > RowsCount
End Function
Public Function BOT() As Boolean
    If tabla Is Nothing Then
        Err.Raise 999, className & ".BOT", "First initialize the table (Call GetTable)"
    End If
    BOT = currentRow < 1
End Function
Public Property Get RowsCount() As Long
    If tabla Is Nothing Then
        Err.Raise 999, className & ".RowsCount", "First initialize the table (Call GetTable)"
    End If
    RowsCount = tabla.ListRows.Count
End Property
Public Sub AddLine(ParamArray valores() As Variant)
    If tabla Is Nothing Then
        Err.Raise 999, className & ".AddLine", "First initialize the table (Call GetTable)"
    End If
    
    Dim linea As ListRow
    Set linea = tabla.ListRows.Add
    
    For i = LBound(valores) To UBound(valores)
        linea.Range(1, i + 1).value = valores(i)
    Next i
End Sub
Public Sub DeleteLinesWhere(columnName As String, operator As ComparationOperator, columnValue As Variant)
    If tabla Is Nothing Then
        Err.Raise 999, className & ".DeleteLinesWhere", "First initialize the table (Call GetTable)"
    End If
    Dim i As Long
    Dim linea As ListRow
    Dim deleteLine As Boolean
    Dim col_index As Long
    Dim thisLineValue As Variant
    
    col_index = tabla.ListColumns(columnName).index
    
    For i = RowsCount To 1 Step -1
        Set linea = tabla.ListRows(i)
        thisLineValue = linea.Range(1, col_index).value
        
        If operator = Equals Then
            deleteLine = thisLineValue = columnValue
        ElseIf operator = Greater Then
            deleteLine = thisLineValue > columnValue
        ElseIf operator = GreaterOrEqual Then
            deleteLine = thisLineValue >= columnValue
        ElseIf operator = IsLike Then
            deleteLine = thisLineValue Like columnValue
        ElseIf operator = LessThan Then
            deleteLine = thisLineValue < columnValue
        ElseIf operator = LessThanOrEqual Then
            deleteLine = thisLineValue <= columnValue
        ElseIf operator = NotEqual Then
            deleteLine = thisLineValue <> columnValue
        End If
        
        If deleteLine Then
            linea.Delete
        End If
    Next i
End Sub

