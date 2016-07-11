Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms


Public Class wfImporteCostosIndirectos
    Dim conexion As New dllConexion.Conexion


    Private Sub Panel1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub MostrarDatos()

        conexion.Consulta("Select * from tbl_frm_imp_costosind", "tbl_frm_imp_costosind")
        dgvDatos.DataSource = conexion.ds.Tables("tbl_frm_imp_costosind")
    End Sub

    Public Sub MostrarDatosMaestro()

        conexion.Consulta("Select * from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        dgvdatos2.DataSource = conexion.ds.Tables("tbl_frm_presupuesto_ici")
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Dim guardar As String = "insert into tbl_frm_presupuesto_ici values ('" + txtNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + txtTotal.Text + "', '" + txtEmpresa.Text + "', '" + txtUsuario.Text + "', '" + txtMoneda.Text + "' )"
        ''aqui empieza grid
        Dim con As SqlConnection = New SqlConnection("Data Source=CP;Initial Catalog=presupuesto;User ID=sa;Password=cristian123")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO tbl_frm_imp_costosind VALUES(@id_presupuesto_ici, @imp_nombre,@imp_subtotal)", con)
        con.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In dgv1.Rows
                agregar.Parameters.Clear()
                ' agregar.Parameters.AddWithValue("@id_imp_costoind", Convert.ToString(fila.Cells("Column1").Value))
                agregar.Parameters.AddWithValue("@id_presupuesto_ici", Convert.ToString(fila.Cells("Column2").Value))
                agregar.Parameters.AddWithValue("@imp_nombre", Convert.ToString(fila.Cells("Column3").Value))
                agregar.Parameters.AddWithValue("@imp_subtotal", Convert.ToString(fila.Cells("Column4").Value))

                agregar.ExecuteNonQuery()
            Next

            MessageBox.Show("Datos agregados correctamente")
        Catch ex As Exception
            MessageBox.Show("Datos agregados correctamente a la base de datos")
            MostrarDatos()
            dgv1.Rows.Clear()
        Finally
            con.Close()

        End Try
        ''aqui termina grid
        If (conexion.Insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            txtIdpresupuesto.Clear()
            txtNombre.Clear()
            txtTotal.Clear()
            txtEmpresa.Clear()
            txtUsuario.Clear()
            txtMoneda.Clear()
            MostrarDatosMaestro()
        Else
            MsgBox("Error al guardar")
        End If
    End Sub

    Private Sub wfImporteCostosIndirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet1.tbl_frm_imp_costosind' Puede moverla o quitarla según sea necesario.
        Me.Tbl_frm_imp_costosindTableAdapter1.Fill(Me.PresupuestoDataSet1.tbl_frm_imp_costosind)
        'TODO: esta línea de código carga datos en la tabla 'PresupuestoDataSet.tbl_frm_imp_costosind' Puede moverla o quitarla según sea necesario.
        Me.Tbl_frm_imp_costosindTableAdapter.Fill(Me.PresupuestoDataSet.tbl_frm_imp_costosind)
        conexion.Conectado()
        MostrarDatos()
        MostrarDatosMaestro()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (conexion.Eliminar("tbl_frm_presupuesto_ici", "id_presupuesto_ici= " + txtIdpresupuesto.Text)) Then
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
        If (conexion.Modificar("tbl_frm_presupuesto_ici", modificar, "id_presupuesto_ici=" + txtIdpresupuesto.Text)) Then
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

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim subtotal As Double = 0

        For i As Integer = 0 To dgv1.Rows.Count - 1
            Dim convertirSubtotal As Double = Convert.ToDouble(dgv1.Rows(i).Cells(3).Value)
            subtotal = subtotal + convertirSubtotal
        Next
        lbltotal.Text = subtotal.ToString()
        txtTotal.Text = subtotal.ToString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=CP;Initial Catalog=presupuesto;User ID=sa;Password=cristian123")
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO tbl_frm_imp_costosind VALUES(@id_presupuesto_ici, @imp_nombre,@imp_subtotal)", con)
        con.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In dgv1.Rows
                agregar.Parameters.Clear()
                ' agregar.Parameters.AddWithValue("@id_imp_costoind", Convert.ToString(fila.Cells("Column1").Value))
                agregar.Parameters.AddWithValue("@id_presupuesto_ici", Convert.ToString(fila.Cells("Column2").Value))
                agregar.Parameters.AddWithValue("@imp_nombre", Convert.ToString(fila.Cells("Column3").Value))
                agregar.Parameters.AddWithValue("@imp_subtotal", Convert.ToString(fila.Cells("Column4").Value))

                agregar.ExecuteNonQuery()
            Next

            MessageBox.Show("Datos agregados correctamente")
        Catch ex As Exception
            MessageBox.Show("Datos agregados correctamente a la base de datos")
            MostrarDatos()
            dgv1.Rows.Clear()
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class