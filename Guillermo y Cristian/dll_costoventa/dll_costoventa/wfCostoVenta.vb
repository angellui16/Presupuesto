'*****Modulo costo de venta*****
'*****Realizado por Cristian Portillo*****
'*****19 de julio del 2016*************
'*****Este modulo realiza la insercion maestra y transaccional del presupuesto costo de venta*****


Imports System.Data
Imports System.Data.SqlClient
Imports dllConexion
Imports System.Windows.Forms

Public Class wfCostoVenta




    Private Sub dgv1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Public Sub MostrarDatosCMD()
        Conexion.Conectado()
        Conexion.Consulta("Select id_compras_matdirectos from tbl_frm_compras_matdirectos", "tbl_frm_compras_matdirectos")
        cboIdcmad.DataSource = Conexion.ds.Tables("tbl_frm_compras_matdirectos")
        cboIdcmad.DisplayMember = "id_compras_matdirectos"
    End Sub

    Public Sub MostrarDatospmod()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_mod from tbl_frm_presupuesto_mod", "tbl_frm_presupuesto_mod")
        cboIdpmod.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_mod")
        cboIdpmod.DisplayMember = "id_presupuesto_mod"
    End Sub

    Public Sub MostrarDatospici()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_ici from tbl_frm_presupuesto_ici", "tbl_frm_presupuesto_ici")
        cboIdici.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_ici")
        cboIdici.DisplayMember = "id_presupuesto_ici"
    End Sub

    Public Sub MostrarDatospcv()
        Conexion.Conectado()
        Conexion.Consulta("Select id_presupuesto_cv from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        cboIdcv.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
        cboIdcv.DisplayMember = "id_presupuesto_cv"
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



    Private Sub wfCostoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosCMD()
        MostrarDatospmod()
        MostrarDatospici()
        MostrarDatospcv()

        MostrarDatosEmpresa()
        MostrarDatosUsuario()
        MostrarDatosMoneda()



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim wfConsultaventa As New wfConsultacv
        wfConsultaventa.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class