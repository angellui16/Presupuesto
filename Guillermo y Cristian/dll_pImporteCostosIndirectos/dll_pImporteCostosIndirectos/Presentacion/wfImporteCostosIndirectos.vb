Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms

Public Class wfImporteCostosIndirectos
    Dim conexion As New dllConexion.Conexion


    Private Sub Panel1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Conexion.Insertar("insert into tbl_frm_presupuesto_ici (id_presupuesto_ici,ici_nombre,ici_periodo,ici_grantotal,id_empresa2,id_usuario,id_moneda2) values ('" & txtIdpresupuesto.Text & "','" & txtNombre.Text & "','" & dtpPeriodo.Value.Date & "','" & txtTotal.Text & "','" & txtEmpresa.Text & "','" & txtUsuario.Text & "','" & txtMoneda.Text & "')")
        Dim guardar As String = "insert into tbl_frm_presupuesto_ici values ('" + txtIdpresupuesto.Text + "', '" + txtNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + txtTotal.Text + "', '" + txtEmpresa.Text + "', '" + txtUsuario.Text + "', '" + txtMoneda.Text + "' )"
        If (Conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            txtIdpresupuesto.Clear()
            txtNombre.Clear()
            txtTotal.Clear()
            txtEmpresa.Clear()
            txtUsuario.Clear()
            txtMoneda.Clear()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub wfImporteCostosIndirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Conexion.Eliminar("tbl_frm_presupuesto_ici", "id_presupuesto_ici= " + txtIdpresupuesto.Text)) Then
            MessageBox.Show("Datos eliminados correctamente")
            txtIdpresupuesto.Clear()
            txtNombre.Clear()
            txtTotal.Clear()
            txtEmpresa.Clear()
            txtUsuario.Clear()
            txtMoneda.Clear()
        Else
            MessageBox.Show("Error al eliminar")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificar As String = "ici_nombre= '" + txtNombre.Text + "', ici_periodo= '" + dtpPeriodo.Value.Date + "', ici_grantotal= '" + txtTotal.Text + "',id_empresa2= '" + txtEmpresa.Text + "',id_usuario= '" + txtUsuario.Text + "',id_moneda2= '" + txtMoneda.Text + "'"
        If (Conexion.Modificar("tbl_frm_presupuesto_ici", modificar, "id_presupuesto_ici=" + txtIdpresupuesto.Text)) Then
            MessageBox.Show("Datos modificados correctamente")
            txtIdpresupuesto.Clear()
            txtNombre.Clear()
            txtTotal.Clear()
            txtEmpresa.Clear()
            txtUsuario.Clear()
            txtMoneda.Clear()
        Else
            MessageBox.Show("Error al modificar")
        End If
    End Sub
End Class