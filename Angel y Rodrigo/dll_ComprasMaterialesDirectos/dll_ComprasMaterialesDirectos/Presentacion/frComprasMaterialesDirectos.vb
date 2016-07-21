Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms

Public Class frComprasMaterialesDirectos
    'NOMBRE:RODRIGO MIRANDA
    'FECHA:
    'CREADOR:	
    'DESCRIPCIÓN	
    'DETALLE
    'MODIFICACIÓN:

    Private Sub frComprasMaterialesDirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Conexion.Insertar("insert into tbl_frm_presupuesto_ici (id_presupuesto_ici,ici_nombre,ici_periodo,ici_grantotal,id_empresa2,id_usuario,id_moneda2) values ('" & txtIdpresupuesto.Text & "','" & txtNombre.Text & "','" & dtpPeriodo.Value.Date & "','" & txtTotal.Text & "','" & txtEmpresa.Text & "','" & txtUsuario.Text & "','" & txtMoneda.Text & "')")
        Dim guardar As String = "INSERT INTO tbl_frm_compras_matdirectos (cmd_nombre,cmd_periodo,cmd_grantotal_matdirectos_compra,cmd_total_matdirectos_estimado,cmd_total_matdirectos_deseado,id_empresa2,id_usuario,id_moneda2) values ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + tbTEstimado.Text + "', '" + tbTDeseado.Text + "', '" + tbEmpresa.Text + "', '" + tbUsuario.Text + "', '" + tbMoneda.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            tbIdpresupuesto.Clear()
            tbNombre.Clear()
            tbGTotal.Clear()
            tbEmpresa.Clear()
            tbTDeseado.Clear()
            tbTEstimado.Clear()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        limpiar.LimpiarCampos(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If (Conexion.Eliminar("tbl_frm_compras_matdirectos", "id_compras_matdirectos= " + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        Dim modificar As String = "cmd_nombre= '" + tbNombre.Text + "', cmd_periodo= '" + dtpPeriodo.Value.Date + "', cmd_grantotal_matdirectos_compra= '" + tbGTotal.Text + "',cmd_total_matdirectos_estimado= '" + tbTEstimado.Text + "',cmd_total_matdirectos_deseado= '" + tbTDeseado.Text + "',id_empresa2= '" + tbEmpresa.Text + "',id_usuario= '" + tbUsuario.Text + "',id_moneda2= '" + tbMoneda.Text + "'"
        If (Conexion.Modificar("tbl_frm_compras_matdirectos", modificar, "id_compras_matdirectos=" + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub
End Class