'*****Modulo importe costos indirectos*****
'*****Realizado por Cristian Portillo*****
'*****15 de julio del 2016*************
'*****Este modulo realiza la insercion maestra y transaccional del presupuesto costos indirectos*****


Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms


Public Class wfImporteCostosIndirectos
    Dim conexion As New dllConexion.Conexion


    Private Sub Panel1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub MostrarDatos()

        Conexion.Consulta("Select * from tbl_frm_imp_costosind", "tbl_frm_imp_costosind")
        dgvDatos.DataSource = Conexion.ds.Tables("tbl_frm_imp_costosind")
    End Sub
    Public Sub MostrarDatosEmpresa()
        Conexion.Conectado()
        Conexion.Consulta("Select id_empresa2 from tbl_frm_empresa2", "tbl_frm_empresa2")
        cboEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cboEmpresa.DisplayMember = "id_empresa2"
    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("Select id_usuario from tbl_frm_usuario", "tbl_frm_usuario")
        cboUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cboUsuario.DisplayMember = "id_usuario"
    End Sub

    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("Select id_moneda2 from tbl_frm_moneda2", "tbl_frm_moneda2")
        cboMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cboMoneda.DisplayMember = "id_moneda2"
    End Sub

    Public Sub MostrarDatosMaestro()

        Conexion.Consulta("Select * from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        dgvdatos2.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ici")
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("Debe llenar todos los datos")
        Else

            Dim guardar As String = "insert into tbl_frm_presupuesto_ici values ('" + txtNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + txtTotal.Text + "', '" + cboEmpresa.Text + "', '" + cboUsuario.Text + "', '" + cboMoneda.Text + "' )"
            ''aqui empieza grid
            Dim con As SqlConnection = Conexion.con
            'Dim con As SqlConnection = New SqlConnection("Data Source=CP;Initial Catalog=presupuesto;User ID=sa;Password=cristian123")

            Dim agregar As SqlCommand = New SqlCommand("INSERT INTO tbl_frm_imp_costosind VALUES(@id_presupuesto_ici, @imp_nombre,@imp_subtotal)", con)
            Conexion.Conectado()

            Dim fila As DataGridViewRow = New DataGridViewRow()
            Try
                For Each fila In dgv1.Rows
                    agregar.Parameters.Clear()

                    agregar.Parameters.AddWithValue("@id_presupuesto_ici", Convert.ToString(fila.Cells("Column2").Value))
                    agregar.Parameters.AddWithValue("@imp_nombre", Convert.ToString(fila.Cells("Column3").Value))
                    agregar.Parameters.AddWithValue("@imp_subtotal", Convert.ToString(fila.Cells("Column4").Value))

                    agregar.ExecuteNonQuery()
                Next

                'MessageBox.Show("Datos agregados correctamente")
            Catch ex As Exception
                'MessageBox.Show("Datos agregados correctamente a la base de datos")
                MostrarDatos()
                dgv1.Rows.Clear()
            Finally
                con.Close()


            End Try
            ''aqui termina grid
            If (Conexion.Insertar(guardar)) Then
                MessageBox.Show("Datos guardados correctamente")
                txtIdpresupuesto.Clear()
                txtNombre.Clear()
                txtTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosUsuario()
                MostrarDatosMoneda()
                MostrarDatosMaestro()
            Else
                MsgBox("Error al guardar")
            End If

        End If
    End Sub

    Private Sub wfImporteCostosIndirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Conectado()
        MostrarDatos()
        MostrarDatosMaestro()
        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(txtIdpresupuesto.Text) Then
                MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else

                If (Conexion.Eliminar("tbl_frm_presupuesto_ici", "id_presupuesto_ici= " + txtIdpresupuesto.Text)) Then
                    MessageBox.Show("Datos eliminados correctamente")
                    txtIdpresupuesto.Clear()
                    txtNombre.Clear()
                    txtTotal.Clear()
                    MostrarDatosEmpresa()
                    MostrarDatosUsuario()
                    MostrarDatosMoneda()
                    dgv1.Rows.Clear()
                    MostrarDatos()
                    MostrarDatosMaestro()

                Else
                    MessageBox.Show("Error al eliminar, el dato no existe")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea cuentas indirectas")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If String.IsNullOrEmpty(txtIdpresupuesto.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "ici_nombre= '" + txtNombre.Text + "', ici_periodo= '" + dtpPeriodo.Value.Date + "', ici_grantotal= '" + txtTotal.Text + "',id_empresa2= '" + cboEmpresa.Text + "',id_usuario= '" + cboUsuario.Text + "',id_moneda2= '" + cboMoneda.Text + "'"
            If (Conexion.Modificar("tbl_frm_presupuesto_ici", modificar, "id_presupuesto_ici=" + txtIdpresupuesto.Text)) Then
                MessageBox.Show("Datos modificados correctamente")
                txtIdpresupuesto.Clear()
                txtNombre.Clear()
                txtTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosUsuario()
                MostrarDatosMoneda()
                dgv1.Rows.Clear()
                MostrarDatos()
                MostrarDatosMaestro()

            Else
                MessageBox.Show("Error al modificar")
            End If

        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)
        Dim subtotal As Double = 0

        For i As Integer = 0 To dgv1.Rows.Count - 1
            Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
            subtotal = subtotal + convertirSubtotal
        Next

        txtTotal.Text = subtotal.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdpresupuesto.Clear()
        txtNombre.Clear()
        txtTotal.Clear()
        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()
        dgv1.Rows.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvdatos2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdatos2.CellContentClick
        Dim dgv As DataGridViewRow = dgvdatos2.Rows(e.RowIndex)
        txtIdpresupuesto.Text = dgv.Cells(0).Value.ToString()
        txtNombre.Text = dgv.Cells(1).Value.ToString()
        dtpPeriodo.Value = dgv.Cells(2).Value.ToString()
        txtTotal.Text = dgv.Cells(3).Value.ToString()
        cboEmpresa.Text = dgv.Cells(4).Value.ToString()
        cboUsuario.Text = dgv.Cells(5).Value.ToString()
        cboMoneda.Text = dgv.Cells(6).Value.ToString()
    End Sub

    Private Sub dgv1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick

    End Sub

    Private Sub dgv1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick

    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim frm As New wfCuentasIndirectas
        Try
            If (e.ColumnIndex.Equals(2)) Then
                frm.Show()
                dgv1.Rows(e.RowIndex).Cells(2).Value = frm.SCuenta1


                'Condicion que nos sirve para verificar si el id del catalogo esta vacio
                If Not String.IsNullOrEmpty(frm.SCuenta1) Then
                    dgv1.Rows.Add()
                    dgv1.CurrentCell = dgv1.Rows(e.RowIndex).Cells(2)
                End If
            End If
            'Suma automatica
            If (e.ColumnIndex.Equals(3)) Then
                Dim subtotal As Double = 0

                For i As Integer = 0 To dgv1.Rows.Count - 1
                    Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
                    subtotal = subtotal + convertirSubtotal
                Next

                txtTotal.Text = subtotal.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Ingrese una cantidad valida")
        End Try
    End Sub

    Private Sub dgv1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.ColumnHeaderMouseClick

    End Sub

    Private Sub dgv1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellEnter
        If (e.ColumnIndex.Equals(3)) Then
            Dim subtotal As Double = 0

            For i As Integer = 0 To dgv1.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
                subtotal = subtotal + convertirSubtotal
            Next

            txtTotal.Text = subtotal.ToString()
        End If
    End Sub

    Private Sub dgv1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellLeave
        If (e.ColumnIndex.Equals(3)) Then
            Dim subtotal As Double = 0

            For i As Integer = 0 To dgv1.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
                subtotal = subtotal + convertirSubtotal
            Next

            txtTotal.Text = subtotal.ToString()
        End If
    End Sub

    Private Sub dgv1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        If (e.ColumnIndex.Equals(3)) Then
            Dim subtotal As Double = 0

            For i As Integer = 0 To dgv1.Rows.Count - 1
                Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
                subtotal = subtotal + convertirSubtotal
            Next

            txtTotal.Text = subtotal.ToString()
        End If
    End Sub

    Private Sub tc1_Click(sender As Object, e As EventArgs) Handles tc1.Click
        txtIdpresupuesto.ReadOnly = True
    End Sub
End Class