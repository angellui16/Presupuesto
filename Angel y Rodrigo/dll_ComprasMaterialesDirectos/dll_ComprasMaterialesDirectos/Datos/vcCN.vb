Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class vcCN
    Public conexion As SqlConnection = New SqlConnection("Data Source=(local);Integrated Security=SSPI;Initial Catalog=presupuesto;")
    'RODRIGO_MIRANDA\SQLEXPRESS
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmdSQL As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
            'MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la BD")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Insertar(ByVal sql)
        conexion.Open()
        cmdSQL = New SqlCommand(sql, conexion)
        Dim i As Integer = cmdSQL.ExecuteNonQuery
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "DELETE FROM " + tabla + " WHERE " + condicion
        cmdSQL = New SqlCommand(elimina, conexion)
        Dim i As Integer = cmdSQL.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    Function Modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "UPDATE " + tabla + " SET " + campos + " where " + condicion
        cmdSQL = New SqlCommand(actualiza, conexion)
        Dim i As Integer = cmdSQL.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
