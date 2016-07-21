Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms
Public Class frCostoManoObraDirecta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        Dim guardar As String = "INSERT INTO tbl_frm_presupuesto_mod values ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + tbEmpresa.Text + "', '" + tbUsuario.Text + "', '" + tbMoneda.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            limpiar.LimpiarCampos(Me)
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
        If (Conexion.Eliminar("tbl_frm_presupuesto_mod", "id_presupuesto_mod= " + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        Dim modificar As String = "mod_nombre= '" + tbNombre.Text + "', mod_periodo= '" + dtpPeriodo.Value.Date + "', mod_grantotal_manoobradirecta= '" + tbGTotal.Text + "',id_empresa2= '" + tbEmpresa.Text + "',id_usuario= '" + tbUsuario.Text + "',id_moneda2= '" + tbMoneda.Text + "'"
        If (Conexion.Modificar("tbl_frm_presupuesto_mod", modificar, "id_presupuesto_mod=" + tbIdpresupuesto.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            limpiar.LimpiarCampos(Me)
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub
End Class