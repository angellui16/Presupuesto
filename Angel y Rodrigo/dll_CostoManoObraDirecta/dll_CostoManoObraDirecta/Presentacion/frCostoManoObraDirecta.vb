Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms
'***************************************************************
'NOMBRE:Presupuesto de costo de mano de obra.
'FECHA: 6/07/2016
'CREADOR:RODRIGO MIRANDA	
'DESCRIPCIÓN	Costo de mano de obra
'DETALLE  Controla las horas requeridas para la producción creciente de productos a producir
'MODIFICACIÓN: 18/07/2016
'***************************************************************
Public Class frCostoManoObraDirecta
    Dim conexion As New dllConexion.Conexion
    Private Sub frCostoManoObraDirecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEmpresa()
        MostrarDatosMoneda()
        MostrarDatosUsuario()
        MostrarMaestro()
        MostrarDetalle()
        MostrarcbControl()
    End Sub

    Public Sub MostrarMaestro()
        Conexion.Consulta("Select * from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        dgCManoObra.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")

        dgCManoObra.AutoResizeColumns()
        dgCManoObra.Columns(0).HeaderText = "ID"
        dgCManoObra.Columns(1).HeaderText = "NOMBRE PRESP."
        dgCManoObra.Columns(2).HeaderText = "FECHA"
        dgCManoObra.Columns(3).HeaderText = "TOTAL M. OBRA"
        dgCManoObra.Columns(4).HeaderText = "ID EMPRESA"
        dgCManoObra.Columns(5).HeaderText = "ID USUARIO"
        dgCManoObra.Columns(6).HeaderText = "ID MONEDA"

    End Sub
    Public Sub MostrarDetalle()
        Conexion.Consulta("Select * from tbl_frm_manoobra", "tbl_frm_manoobra")
        dgCDMO.DataSource = Conexion.ds.Tables("tbl_frm_manoobra")
    End Sub
    Public Sub MostrarDatosEmpresa()
        'conexion.Conectar()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_empresa2,emp_nombre_empresa2 FROM tbl_frm_empresa2", "tbl_frm_empresa2")
        cbEmpresa.DataSource = Conexion.ds.Tables("tbl_frm_empresa2")
        cbEmpresa.DisplayMember = "emp_nombre_empresa2"
        cbEmpresa.ValueMember = "id_empresa2"
    End Sub
    Public Sub MostrarDatosUsuario()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_usuario,usr_usuario FROM tbl_frm_usuario", "tbl_frm_usuario")
        cbUsuario.DataSource = Conexion.ds.Tables("tbl_frm_usuario")
        cbUsuario.DisplayMember = "usr_usuario"
        cbUsuario.ValueMember = "id_usuario"
    End Sub
    Public Sub MostrarDatosMoneda()
        Conexion.Conectado()
        Conexion.Consulta("SELECT id_moneda2,mnd_moneda2 FROM tbl_frm_moneda2", "tbl_frm_moneda2")
        cbMoneda.DataSource = Conexion.ds.Tables("tbl_frm_moneda2")
        cbMoneda.DisplayMember = "mnd_moneda2"
        cbMoneda.ValueMember = "id_moneda2"
    End Sub
    'Llenar id aplicación
    Public Sub MostrarcbControl()
        Conexion.Conectado()
        Conexion.Consulta("select id_presupuesto_mod from tbl_frm_presupuesto_mod order by id_presupuesto_mod desc ", "tbl_frm_presupuesto_mod")
        cbControl.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")
        cbControl.DisplayMember = "id_presupuesto_mod"
        tbControl.Text = cbControl.Text

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
        Try
            If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
                MessageBox.Show("Debe ingresar un ID de presupuesto valido")
            Else
                Dim limpiar As vcLimpiar = New vcLimpiar()
                If (Conexion.Eliminar("tbl_frm_presupuesto_mod", "id_presupuesto_mod= " + tbIdpresupuesto.Text)) Then
                    MessageBox.Show("Datos eliminados correctamente")
                    limpiar.LimpiarCampos(Me)
                    tbIdpresupuesto.Clear()
                    tbNombre.Clear()
                    tbGTotal.Clear()
                    MostrarDatosEmpresa()
                    MostrarDatosMoneda()
                    MostrarDatosUsuario()
                    MostrarMaestro()
                    MostrarDetalle()
                    MostrarcbControl()
                Else
                    MessageBox.Show("Error al eliminar")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("El archivo no pudo eliminarse compruebe que no posea cuentas indirectas")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim limpiar As vcLimpiar = New vcLimpiar()
        If String.IsNullOrEmpty(tbIdpresupuesto.Text) Then
            MessageBox.Show("Debe ingresar un ID de presupuesto valido")
        Else
            Dim modificar As String = "mod_nombre= '" + tbNombre.Text + "', mod_periodo= '" + dtpPeriodo.Value.Date + "', mod_grantotal_manoobradirecta= '" + tbGTotal.Text + "',id_empresa2= '" + cbEmpresa.SelectedValue.ToString + "',id_usuario= '" + cbUsuario.SelectedValue.ToString + "',id_moneda2= '" + cbMoneda.SelectedValue.ToString + "'"
            If (Conexion.Modificar("tbl_frm_presupuesto_mod", modificar, "id_presupuesto_mod=" + tbIdpresupuesto.Text)) Then
                MessageBox.Show("Datos modificados correctamente")
                limpiar.LimpiarCampos(Me)
                tbIdpresupuesto.Clear()
                tbNombre.Clear()
                tbGTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosMoneda()
                MostrarDatosUsuario()
                MostrarMaestro()
                MostrarDetalle()
                MostrarcbControl()
            Else
                MessageBox.Show("Error al modificar")
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnGuardarMaestro_Click(sender As Object, e As EventArgs) Handles btnGuardarMaestro.Click
        If String.IsNullOrEmpty(tbNombre.Text) Then
            MessageBox.Show("Debe llenar todos los datos")
        Else
            'Master
            Dim guardar As String = "INSERT INTO tbl_frm_presupuesto_mod VALUES ('" + tbNombre.Text + "', '" + dtpPeriodo.Value.Date + "', '" + tbGTotal.Text + "', '" + cbEmpresa.SelectedValue.ToString + "', '" + cbUsuario.SelectedValue.ToString + "', '" + cbMoneda.SelectedValue.ToString + "' )"
            ''aqui empieza grid
            Dim con As SqlConnection = Conexion.con

            ''aqui termina grid
            If (Conexion.Insertar(guardar)) Then
                MessageBox.Show("Datos guardados correctamente")
                tbIdpresupuesto.Clear()
                tbNombre.Clear()
                tbGTotal.Clear()
                MostrarDatosEmpresa()
                MostrarDatosMoneda()
                MostrarDatosUsuario()
                MostrarMaestro()
                MostrarDetalle()
                MostrarcbControl()

                dgUltimo.Visible = True
                dgUltimo2.Visible = True
                btnGuardar.Enabled = True
            Else
                MsgBox("Error al guardar")
            End If

        End If
    End Sub
End Class