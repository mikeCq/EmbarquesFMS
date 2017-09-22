<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Embarques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TbTelefonoAgricultor = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TbDireccion = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbCelular = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbAgenciaAduanal = New System.Windows.Forms.TextBox()
        Me.TbAnticipo = New System.Windows.Forms.TextBox()
        Me.TbDescuentoFlete = New System.Windows.Forms.TextBox()
        Me.TbFlete = New System.Windows.Forms.TextBox()
        Me.TbTelefonoDueno = New System.Windows.Forms.TextBox()
        Me.TbDueno = New System.Windows.Forms.TextBox()
        Me.TbNoLicencia = New System.Windows.Forms.TextBox()
        Me.TbTelefonoOperador = New System.Windows.Forms.TextBox()
        Me.TbOperador = New System.Windows.Forms.TextBox()
        Me.TbPlacasJaula = New System.Windows.Forms.TextBox()
        Me.TbPlacasTractor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbNoSerie = New System.Windows.Forms.TextBox()
        Me.TbAnio = New System.Windows.Forms.TextBox()
        Me.TbNoMotor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbColor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbMarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbNoGuia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbLineaTransporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbObservaciones = New System.Windows.Forms.TextBox()
        Me.CbSandia = New System.Windows.Forms.ComboBox()
        Me.TbPeso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbAgricultores = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNoFactura = New System.Windows.Forms.TextBox()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbFiltros = New System.Windows.Forms.GroupBox()
        Me.BtFiltrar = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CbSandiaFiltro = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DgvEmbarques = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbFiltros.SuspendLayout()
        CType(Me.DgvEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1185, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ConsultarToolStripMenuItem.Text = "Imprimir"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SairToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label30)
        Me.GbDatosGenerales.Controls.Add(Me.Label31)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefonoAgricultor)
        Me.GbDatosGenerales.Controls.Add(Me.Label26)
        Me.GbDatosGenerales.Controls.Add(Me.TbDireccion)
        Me.GbDatosGenerales.Controls.Add(Me.Label25)
        Me.GbDatosGenerales.Controls.Add(Me.Label24)
        Me.GbDatosGenerales.Controls.Add(Me.Label23)
        Me.GbDatosGenerales.Controls.Add(Me.Label22)
        Me.GbDatosGenerales.Controls.Add(Me.Label21)
        Me.GbDatosGenerales.Controls.Add(Me.Label20)
        Me.GbDatosGenerales.Controls.Add(Me.Label19)
        Me.GbDatosGenerales.Controls.Add(Me.Label18)
        Me.GbDatosGenerales.Controls.Add(Me.Label17)
        Me.GbDatosGenerales.Controls.Add(Me.Label16)
        Me.GbDatosGenerales.Controls.Add(Me.Label15)
        Me.GbDatosGenerales.Controls.Add(Me.Label14)
        Me.GbDatosGenerales.Controls.Add(Me.Label13)
        Me.GbDatosGenerales.Controls.Add(Me.TbCelular)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefono)
        Me.GbDatosGenerales.Controls.Add(Me.TbAgenciaAduanal)
        Me.GbDatosGenerales.Controls.Add(Me.TbAnticipo)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescuentoFlete)
        Me.GbDatosGenerales.Controls.Add(Me.TbFlete)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefonoDueno)
        Me.GbDatosGenerales.Controls.Add(Me.TbDueno)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoLicencia)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefonoOperador)
        Me.GbDatosGenerales.Controls.Add(Me.TbOperador)
        Me.GbDatosGenerales.Controls.Add(Me.TbPlacasJaula)
        Me.GbDatosGenerales.Controls.Add(Me.TbPlacasTractor)
        Me.GbDatosGenerales.Controls.Add(Me.Label12)
        Me.GbDatosGenerales.Controls.Add(Me.Label11)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoSerie)
        Me.GbDatosGenerales.Controls.Add(Me.TbAnio)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoMotor)
        Me.GbDatosGenerales.Controls.Add(Me.Label10)
        Me.GbDatosGenerales.Controls.Add(Me.Label9)
        Me.GbDatosGenerales.Controls.Add(Me.TbColor)
        Me.GbDatosGenerales.Controls.Add(Me.Label8)
        Me.GbDatosGenerales.Controls.Add(Me.TbMarca)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoGuia)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.TbLineaTransporte)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.TbObservaciones)
        Me.GbDatosGenerales.Controls.Add(Me.CbSandia)
        Me.GbDatosGenerales.Controls.Add(Me.TbPeso)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.CbAgricultores)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoFactura)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdEmbarque)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(12, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(535, 607)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(243, 127)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 13)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "Tipo"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(359, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 13)
        Me.Label31.TabIndex = 53
        Me.Label31.Text = "Telefono"
        '
        'TbTelefonoAgricultor
        '
        Me.TbTelefonoAgricultor.Location = New System.Drawing.Point(414, 100)
        Me.TbTelefonoAgricultor.Name = "TbTelefonoAgricultor"
        Me.TbTelefonoAgricultor.Size = New System.Drawing.Size(108, 20)
        Me.TbTelefonoAgricultor.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 103)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Direccion"
        '
        'TbDireccion
        '
        Me.TbDireccion.Location = New System.Drawing.Point(116, 100)
        Me.TbDireccion.Name = "TbDireccion"
        Me.TbDireccion.Size = New System.Drawing.Size(219, 20)
        Me.TbDireccion.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(359, 580)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Celular"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 580)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Telefono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 553)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 13)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Agencia Aduanal"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 526)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Anticipo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(299, 498)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Menos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 499)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Pagar Flete"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(359, 472)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Telefono"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 472)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Dueño"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 445)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Licencia Numero"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(359, 418)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 418)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Operador"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 391)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Placas de Jaula"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Placas de Tractor"
        '
        'TbCelular
        '
        Me.TbCelular.Location = New System.Drawing.Point(414, 577)
        Me.TbCelular.Name = "TbCelular"
        Me.TbCelular.Size = New System.Drawing.Size(108, 20)
        Me.TbCelular.TabIndex = 28
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(116, 577)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(177, 20)
        Me.TbTelefono.TabIndex = 27
        '
        'TbAgenciaAduanal
        '
        Me.TbAgenciaAduanal.Location = New System.Drawing.Point(116, 550)
        Me.TbAgenciaAduanal.Name = "TbAgenciaAduanal"
        Me.TbAgenciaAduanal.Size = New System.Drawing.Size(406, 20)
        Me.TbAgenciaAduanal.TabIndex = 26
        '
        'TbAnticipo
        '
        Me.TbAnticipo.Location = New System.Drawing.Point(116, 523)
        Me.TbAnticipo.Name = "TbAnticipo"
        Me.TbAnticipo.Size = New System.Drawing.Size(177, 20)
        Me.TbAnticipo.TabIndex = 25
        '
        'TbDescuentoFlete
        '
        Me.TbDescuentoFlete.Location = New System.Drawing.Point(374, 495)
        Me.TbDescuentoFlete.Name = "TbDescuentoFlete"
        Me.TbDescuentoFlete.Size = New System.Drawing.Size(148, 20)
        Me.TbDescuentoFlete.TabIndex = 24
        '
        'TbFlete
        '
        Me.TbFlete.Location = New System.Drawing.Point(116, 496)
        Me.TbFlete.Name = "TbFlete"
        Me.TbFlete.Size = New System.Drawing.Size(177, 20)
        Me.TbFlete.TabIndex = 23
        '
        'TbTelefonoDueno
        '
        Me.TbTelefonoDueno.Location = New System.Drawing.Point(414, 469)
        Me.TbTelefonoDueno.Name = "TbTelefonoDueno"
        Me.TbTelefonoDueno.Size = New System.Drawing.Size(108, 20)
        Me.TbTelefonoDueno.TabIndex = 22
        '
        'TbDueno
        '
        Me.TbDueno.Location = New System.Drawing.Point(116, 469)
        Me.TbDueno.Name = "TbDueno"
        Me.TbDueno.Size = New System.Drawing.Size(177, 20)
        Me.TbDueno.TabIndex = 21
        '
        'TbNoLicencia
        '
        Me.TbNoLicencia.Location = New System.Drawing.Point(116, 442)
        Me.TbNoLicencia.Name = "TbNoLicencia"
        Me.TbNoLicencia.Size = New System.Drawing.Size(177, 20)
        Me.TbNoLicencia.TabIndex = 20
        '
        'TbTelefonoOperador
        '
        Me.TbTelefonoOperador.Location = New System.Drawing.Point(414, 415)
        Me.TbTelefonoOperador.Name = "TbTelefonoOperador"
        Me.TbTelefonoOperador.Size = New System.Drawing.Size(108, 20)
        Me.TbTelefonoOperador.TabIndex = 19
        '
        'TbOperador
        '
        Me.TbOperador.Location = New System.Drawing.Point(116, 415)
        Me.TbOperador.Name = "TbOperador"
        Me.TbOperador.Size = New System.Drawing.Size(177, 20)
        Me.TbOperador.TabIndex = 18
        '
        'TbPlacasJaula
        '
        Me.TbPlacasJaula.Location = New System.Drawing.Point(116, 388)
        Me.TbPlacasJaula.Name = "TbPlacasJaula"
        Me.TbPlacasJaula.Size = New System.Drawing.Size(177, 20)
        Me.TbPlacasJaula.TabIndex = 17
        '
        'TbPlacasTractor
        '
        Me.TbPlacasTractor.Location = New System.Drawing.Point(116, 361)
        Me.TbPlacasTractor.Name = "TbPlacasTractor"
        Me.TbPlacasTractor.Size = New System.Drawing.Size(177, 20)
        Me.TbPlacasTractor.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "No. de Serie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Año"
        '
        'TbNoSerie
        '
        Me.TbNoSerie.Location = New System.Drawing.Point(374, 333)
        Me.TbNoSerie.Name = "TbNoSerie"
        Me.TbNoSerie.Size = New System.Drawing.Size(148, 20)
        Me.TbNoSerie.TabIndex = 15
        '
        'TbAnio
        '
        Me.TbAnio.Location = New System.Drawing.Point(116, 334)
        Me.TbAnio.MaxLength = 4
        Me.TbAnio.Name = "TbAnio"
        Me.TbAnio.Size = New System.Drawing.Size(177, 20)
        Me.TbAnio.TabIndex = 14
        '
        'TbNoMotor
        '
        Me.TbNoMotor.Location = New System.Drawing.Point(374, 306)
        Me.TbNoMotor.Name = "TbNoMotor"
        Me.TbNoMotor.Size = New System.Drawing.Size(148, 20)
        Me.TbNoMotor.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "No. de Motor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Color"
        '
        'TbColor
        '
        Me.TbColor.Location = New System.Drawing.Point(116, 307)
        Me.TbColor.Name = "TbColor"
        Me.TbColor.Size = New System.Drawing.Size(177, 20)
        Me.TbColor.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Camion Marca"
        '
        'TbMarca
        '
        Me.TbMarca.Location = New System.Drawing.Point(116, 280)
        Me.TbMarca.Name = "TbMarca"
        Me.TbMarca.Size = New System.Drawing.Size(406, 20)
        Me.TbMarca.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Guia No."
        '
        'TbNoGuia
        '
        Me.TbNoGuia.Location = New System.Drawing.Point(116, 253)
        Me.TbNoGuia.Name = "TbNoGuia"
        Me.TbNoGuia.Size = New System.Drawing.Size(177, 20)
        Me.TbNoGuia.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Linea de Transporte"
        '
        'TbLineaTransporte
        '
        Me.TbLineaTransporte.Location = New System.Drawing.Point(116, 226)
        Me.TbLineaTransporte.Name = "TbLineaTransporte"
        Me.TbLineaTransporte.Size = New System.Drawing.Size(406, 20)
        Me.TbLineaTransporte.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Observaciones"
        '
        'TbObservaciones
        '
        Me.TbObservaciones.Location = New System.Drawing.Point(116, 151)
        Me.TbObservaciones.Multiline = True
        Me.TbObservaciones.Name = "TbObservaciones"
        Me.TbObservaciones.Size = New System.Drawing.Size(406, 68)
        Me.TbObservaciones.TabIndex = 8
        '
        'CbSandia
        '
        Me.CbSandia.FormattingEnabled = True
        Me.CbSandia.Location = New System.Drawing.Point(302, 124)
        Me.CbSandia.Name = "CbSandia"
        Me.CbSandia.Size = New System.Drawing.Size(178, 21)
        Me.CbSandia.TabIndex = 7
        '
        'TbPeso
        '
        Me.TbPeso.Location = New System.Drawing.Point(116, 124)
        Me.TbPeso.Name = "TbPeso"
        Me.TbPeso.Size = New System.Drawing.Size(121, 20)
        Me.TbPeso.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Peso(Kgs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agricultor(es)"
        '
        'CbAgricultores
        '
        Me.CbAgricultores.FormattingEnabled = True
        Me.CbAgricultores.Location = New System.Drawing.Point(116, 73)
        Me.CbAgricultores.Name = "CbAgricultores"
        Me.CbAgricultores.Size = New System.Drawing.Size(406, 21)
        Me.CbAgricultores.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fact. No"
        '
        'TbNoFactura
        '
        Me.TbNoFactura.Location = New System.Drawing.Point(116, 46)
        Me.TbNoFactura.Name = "TbNoFactura"
        Me.TbNoFactura.Size = New System.Drawing.Size(100, 20)
        Me.TbNoFactura.TabIndex = 2
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Enabled = False
        Me.TbIdEmbarque.Location = New System.Drawing.Point(116, 19)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(50, 20)
        Me.TbIdEmbarque.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Embarque No."
        '
        'GbFiltros
        '
        Me.GbFiltros.Controls.Add(Me.DgvEmbarques)
        Me.GbFiltros.Controls.Add(Me.BtFiltrar)
        Me.GbFiltros.Controls.Add(Me.Label29)
        Me.GbFiltros.Controls.Add(Me.CbSandiaFiltro)
        Me.GbFiltros.Controls.Add(Me.Label28)
        Me.GbFiltros.Controls.Add(Me.DtpFechaFin)
        Me.GbFiltros.Controls.Add(Me.DtpFechaInicio)
        Me.GbFiltros.Controls.Add(Me.Label27)
        Me.GbFiltros.Location = New System.Drawing.Point(553, 27)
        Me.GbFiltros.Name = "GbFiltros"
        Me.GbFiltros.Size = New System.Drawing.Size(632, 607)
        Me.GbFiltros.TabIndex = 56
        Me.GbFiltros.TabStop = False
        Me.GbFiltros.Text = "Filtros"
        '
        'BtFiltrar
        '
        Me.BtFiltrar.Location = New System.Drawing.Point(214, 68)
        Me.BtFiltrar.Name = "BtFiltrar"
        Me.BtFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.BtFiltrar.TabIndex = 6
        Me.BtFiltrar.Text = "Filtrar"
        Me.BtFiltrar.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 71)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Sandia"
        '
        'CbSandiaFiltro
        '
        Me.CbSandiaFiltro.FormattingEnabled = True
        Me.CbSandiaFiltro.Location = New System.Drawing.Point(87, 68)
        Me.CbSandiaFiltro.Name = "CbSandiaFiltro"
        Me.CbSandiaFiltro.Size = New System.Drawing.Size(121, 21)
        Me.CbSandiaFiltro.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(54, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Fecha Fin"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Location = New System.Drawing.Point(87, 41)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaFin.TabIndex = 2
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Location = New System.Drawing.Point(87, 14)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaInicio.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Fecha Inicio"
        '
        'DgvEmbarques
        '
        Me.DgvEmbarques.AllowUserToAddRows = False
        Me.DgvEmbarques.AllowUserToDeleteRows = False
        Me.DgvEmbarques.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvEmbarques.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvEmbarques.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmbarques.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmbarques.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvEmbarques.Location = New System.Drawing.Point(6, 95)
        Me.DgvEmbarques.Name = "DgvEmbarques"
        Me.DgvEmbarques.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvEmbarques.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvEmbarques.RowHeadersVisible = False
        Me.DgvEmbarques.RowHeadersWidth = 40
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvEmbarques.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvEmbarques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmbarques.Size = New System.Drawing.Size(620, 502)
        Me.DgvEmbarques.TabIndex = 20
        '
        'Embarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 642)
        Me.Controls.Add(Me.GbFiltros)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Embarques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Embarques"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbFiltros.ResumeLayout(False)
        Me.GbFiltros.PerformLayout()
        CType(Me.DgvEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents CbSandia As ComboBox
    Friend WithEvents TbPeso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbAgricultores As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNoFactura As TextBox
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbObservaciones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbLineaTransporte As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCelular As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbAgenciaAduanal As TextBox
    Friend WithEvents TbAnticipo As TextBox
    Friend WithEvents TbDescuentoFlete As TextBox
    Friend WithEvents TbFlete As TextBox
    Friend WithEvents TbTelefonoDueno As TextBox
    Friend WithEvents TbDueno As TextBox
    Friend WithEvents TbNoLicencia As TextBox
    Friend WithEvents TbTelefonoOperador As TextBox
    Friend WithEvents TbOperador As TextBox
    Friend WithEvents TbPlacasJaula As TextBox
    Friend WithEvents TbPlacasTractor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbNoSerie As TextBox
    Friend WithEvents TbAnio As TextBox
    Friend WithEvents TbNoMotor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbColor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbMarca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbNoGuia As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TbDireccion As TextBox
    Friend WithEvents GbFiltros As GroupBox
    Friend WithEvents BtFiltrar As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents CbSandiaFiltro As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents DtpFechaFin As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TbTelefonoAgricultor As TextBox
    Friend WithEvents DgvEmbarques As DataGridView
End Class
