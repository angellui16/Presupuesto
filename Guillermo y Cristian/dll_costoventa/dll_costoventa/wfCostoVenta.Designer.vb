<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wfCostoVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtIdcostoventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpcv_grantotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtalmacen_artterminados_deseado = New System.Windows.Forms.TextBox()
        Me.txtcostart_termdispo = New System.Windows.Forms.TextBox()
        Me.txtcostprod_artterminados = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtproduccion_proceso_inv_deseado = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txttotal_prod_proceso = New System.Windows.Forms.TextBox()
        Me.txttotal_costo_produccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcosto_matd_traspasadosp = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtresta_matd_invmatd = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtproduccion_proceso_inv_estimado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtalmacen_arterminados_deseado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboIdcv = New System.Windows.Forms.ComboBox()
        Me.cboIdici = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboIdpmod = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboIdcmad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdce = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(14, 89)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(44, 15)
        Me.lblFecha.TabIndex = 28
        Me.lblFecha.Text = "Fecha:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnConsulta)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Location = New System.Drawing.Point(-1, 576)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1362, 68)
        Me.Panel2.TabIndex = 25
        '
        'btnConsulta
        '
        Me.btnConsulta.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.find
        Me.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsulta.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnConsulta.FlatAppearance.BorderSize = 0
        Me.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsulta.Location = New System.Drawing.Point(437, 3)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(65, 50)
        Me.btnConsulta.TabIndex = 5
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.multiply
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(656, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(65, 50)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.refresh4
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(579, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(65, 50)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.inside
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(736, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(65, 50)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.Floppy_disk_512
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(508, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 50)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtIdcostoventa
        '
        Me.txtIdcostoventa.Location = New System.Drawing.Point(234, 28)
        Me.txtIdcostoventa.Name = "txtIdcostoventa"
        Me.txtIdcostoventa.ReadOnly = True
        Me.txtIdcostoventa.Size = New System.Drawing.Size(59, 22)
        Me.txtIdcostoventa.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Id presupuesto costo de venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Presupuesto de costo de venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(544, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Empresa:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Nombre presupuesto costo de venta:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(234, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(161, 22)
        Me.txtNombre.TabIndex = 36
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(234, 86)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 22)
        Me.dtpFecha.TabIndex = 37
        Me.dtpFecha.Value = New Date(2016, 7, 6, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(543, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(544, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Moneda:"
        '
        'txtpcv_grantotal
        '
        Me.txtpcv_grantotal.Location = New System.Drawing.Point(139, 35)
        Me.txtpcv_grantotal.Name = "txtpcv_grantotal"
        Me.txtpcv_grantotal.Size = New System.Drawing.Size(100, 22)
        Me.txtpcv_grantotal.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Total presupuesto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMoneda)
        Me.GroupBox1.Controls.Add(Me.cboUsuario)
        Me.GroupBox1.Controls.Add(Me.cboEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdcostoventa)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 121)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado presupuesto costo de venta"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(613, 84)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(59, 24)
        Me.cboMoneda.TabIndex = 47
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(613, 50)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(59, 24)
        Me.cboUsuario.TabIndex = 46
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(613, 21)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(59, 24)
        Me.cboEmpresa.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtalmacen_artterminados_deseado)
        Me.GroupBox2.Controls.Add(Me.txtcostart_termdispo)
        Me.GroupBox2.Controls.Add(Me.txtcostprod_artterminados)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtproduccion_proceso_inv_deseado)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txttotal_prod_proceso)
        Me.GroupBox2.Controls.Add(Me.txttotal_costo_produccion)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtcosto_matd_traspasadosp)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtresta_matd_invmatd)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtproduccion_proceso_inv_estimado)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtalmacen_arterminados_deseado)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboIdcv)
        Me.GroupBox2.Controls.Add(Me.cboIdici)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboIdpmod)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboIdcmad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtIdce)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 301)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Formulario costo de venta"
        '
        'txtalmacen_artterminados_deseado
        '
        Me.txtalmacen_artterminados_deseado.Location = New System.Drawing.Point(631, 261)
        Me.txtalmacen_artterminados_deseado.Name = "txtalmacen_artterminados_deseado"
        Me.txtalmacen_artterminados_deseado.Size = New System.Drawing.Size(120, 22)
        Me.txtalmacen_artterminados_deseado.TabIndex = 70
        '
        'txtcostart_termdispo
        '
        Me.txtcostart_termdispo.Location = New System.Drawing.Point(631, 230)
        Me.txtcostart_termdispo.Name = "txtcostart_termdispo"
        Me.txtcostart_termdispo.Size = New System.Drawing.Size(120, 22)
        Me.txtcostart_termdispo.TabIndex = 69
        '
        'txtcostprod_artterminados
        '
        Me.txtcostprod_artterminados.Location = New System.Drawing.Point(629, 199)
        Me.txtcostprod_artterminados.Name = "txtcostprod_artterminados"
        Me.txtcostprod_artterminados.Size = New System.Drawing.Size(120, 22)
        Me.txtcostprod_artterminados.TabIndex = 68
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(383, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(240, 15)
        Me.Label22.TabIndex = 67
        Me.Label22.Text = "Almacen de articulos terminados deseado:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(383, 237)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(232, 15)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Costo de articulos terminados disponible:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(383, 207)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(221, 15)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "Costo de produccion de art. terminados"
        '
        'txtproduccion_proceso_inv_deseado
        '
        Me.txtproduccion_proceso_inv_deseado.Location = New System.Drawing.Point(628, 170)
        Me.txtproduccion_proceso_inv_deseado.Name = "txtproduccion_proceso_inv_deseado"
        Me.txtproduccion_proceso_inv_deseado.Size = New System.Drawing.Size(120, 22)
        Me.txtproduccion_proceso_inv_deseado.TabIndex = 64
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(383, 179)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 15)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Prod. en proceso inventario deseado:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(383, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 15)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Total produccion en proceso"
        '
        'txttotal_prod_proceso
        '
        Me.txttotal_prod_proceso.Location = New System.Drawing.Point(628, 142)
        Me.txttotal_prod_proceso.Name = "txttotal_prod_proceso"
        Me.txttotal_prod_proceso.Size = New System.Drawing.Size(120, 22)
        Me.txttotal_prod_proceso.TabIndex = 62
        '
        'txttotal_costo_produccion
        '
        Me.txttotal_costo_produccion.Location = New System.Drawing.Point(257, 265)
        Me.txttotal_costo_produccion.Name = "txttotal_costo_produccion"
        Me.txttotal_costo_produccion.Size = New System.Drawing.Size(120, 22)
        Me.txttotal_costo_produccion.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 15)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Total costo de produccion:"
        '
        'txtcosto_matd_traspasadosp
        '
        Me.txtcosto_matd_traspasadosp.Location = New System.Drawing.Point(257, 230)
        Me.txtcosto_matd_traspasadosp.Name = "txtcosto_matd_traspasadosp"
        Me.txtcosto_matd_traspasadosp.Size = New System.Drawing.Size(120, 22)
        Me.txtcosto_matd_traspasadosp.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(241, 15)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Costos de materiales directos traspasados:"
        '
        'txtresta_matd_invmatd
        '
        Me.txtresta_matd_invmatd.Location = New System.Drawing.Point(257, 200)
        Me.txtresta_matd_invmatd.Name = "txtresta_matd_invmatd"
        Me.txtresta_matd_invmatd.Size = New System.Drawing.Size(120, 22)
        Me.txtresta_matd_invmatd.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 15)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Inventario de materiales directos:"
        '
        'txtproduccion_proceso_inv_estimado
        '
        Me.txtproduccion_proceso_inv_estimado.Location = New System.Drawing.Point(257, 172)
        Me.txtproduccion_proceso_inv_estimado.Name = "txtproduccion_proceso_inv_estimado"
        Me.txtproduccion_proceso_inv_estimado.Size = New System.Drawing.Size(120, 22)
        Me.txtproduccion_proceso_inv_estimado.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 15)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Produccion en proceso"
        '
        'txtalmacen_arterminados_deseado
        '
        Me.txtalmacen_arterminados_deseado.Location = New System.Drawing.Point(257, 142)
        Me.txtalmacen_arterminados_deseado.Name = "txtalmacen_arterminados_deseado"
        Me.txtalmacen_arterminados_deseado.Size = New System.Drawing.Size(120, 22)
        Me.txtalmacen_arterminados_deseado.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 15)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Almacen de articulos terminados:"
        '
        'cboIdcv
        '
        Me.cboIdcv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdcv.FormattingEnabled = True
        Me.cboIdcv.Location = New System.Drawing.Point(613, 62)
        Me.cboIdcv.Name = "cboIdcv"
        Me.cboIdcv.Size = New System.Drawing.Size(59, 24)
        Me.cboIdcv.TabIndex = 50
        '
        'cboIdici
        '
        Me.cboIdici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdici.FormattingEnabled = True
        Me.cboIdici.Location = New System.Drawing.Point(613, 25)
        Me.cboIdici.Name = "cboIdici"
        Me.cboIdici.Size = New System.Drawing.Size(59, 24)
        Me.cboIdici.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(378, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Id presupuesto costo de venta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(378, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(218, 15)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Id presupuesto importe costo indirecto:"
        '
        'cboIdpmod
        '
        Me.cboIdpmod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdpmod.FormattingEnabled = True
        Me.cboIdpmod.Location = New System.Drawing.Point(234, 102)
        Me.cboIdpmod.Name = "cboIdpmod"
        Me.cboIdpmod.Size = New System.Drawing.Size(59, 24)
        Me.cboIdpmod.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Id presupuesto mano de obra directa"
        '
        'cboIdcmad
        '
        Me.cboIdcmad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdcmad.FormattingEnabled = True
        Me.cboIdcmad.Location = New System.Drawing.Point(234, 60)
        Me.cboIdcmad.Name = "cboIdcmad"
        Me.cboIdcmad.Size = New System.Drawing.Size(59, 24)
        Me.cboIdcmad.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Id compras materiales directos:"
        '
        'txtIdce
        '
        Me.txtIdce.Location = New System.Drawing.Point(234, 25)
        Me.txtIdce.Name = "txtIdce"
        Me.txtIdce.ReadOnly = True
        Me.txtIdce.Size = New System.Drawing.Size(59, 22)
        Me.txtIdce.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Id formulario costo de venta:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtpcv_grantotal)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 496)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(758, 74)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total presupuesto costo de venta"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.dll_costoventa.My.Resources.Resources.contactbook
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(160, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 26
        Me.Button1.UseVisualStyleBackColor = True
        '
        'wfCostoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(806, 641)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "wfCostoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wfCostoVenta"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtIdcostoventa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpcv_grantotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboIdcv As System.Windows.Forms.ComboBox
    Friend WithEvents cboIdici As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboIdpmod As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboIdcmad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdce As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtproduccion_proceso_inv_deseado As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txttotal_prod_proceso As System.Windows.Forms.TextBox
    Friend WithEvents txttotal_costo_produccion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcosto_matd_traspasadosp As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtresta_matd_invmatd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtproduccion_proceso_inv_estimado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtalmacen_arterminados_deseado As System.Windows.Forms.TextBox
    Friend WithEvents txtalmacen_artterminados_deseado As System.Windows.Forms.TextBox
    Friend WithEvents txtcostart_termdispo As System.Windows.Forms.TextBox
    Friend WithEvents txtcostprod_artterminados As System.Windows.Forms.TextBox
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
End Class
