Imports dllConexion

Public Class wfConsultacv
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
    Public Sub MostrarDatosEncabezado()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_presupuesto_cv", "tbl_frm_presupuesto_cv")
        dgvEncabezado.DataSource = Conexion.ds.Tables("tbl_frm_presupuesto_cv")
    End Sub

    Public Sub MostrarDatosFormulario()
        Conexion.Conectado()
        Conexion.Consulta("Select * from tbl_frm_costos_equivalentes", "tbl_frm_costos_equivalentes")
        dgvForm.DataSource = Conexion.ds.Tables("tbl_frm_costos_equivalentes")
    End Sub

    Private Sub wfConsultacv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosEncabezado()
        MostrarDatosFormulario()
    End Sub
End Class