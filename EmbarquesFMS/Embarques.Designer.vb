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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
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
        Me.DgvEmbarques = New System.Windows.Forms.DataGridView()
        Me.BtFiltrar = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CbSandiaFiltro = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
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
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label30)
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
        Me.GbDatosGenerales.Size = New System.Drawing.Size(535, 583)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(243, 104)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 13)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "Tipo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(243, 76)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Direccion"
        '
        'TbDireccion
        '
        Me.TbDireccion.Location = New System.Drawing.Point(302, 73)
        Me.TbDireccion.Name = "TbDireccion"
        Me.TbDireccion.Size = New System.Drawing.Size(220, 20)
        Me.TbDireccion.TabIndex = 52
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(299, 557)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Celular"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 557)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Telefono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 530)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 13)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Agencia Aduanal"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 503)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Anticipo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(299, 475)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Menos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 476)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Pagar Flete"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(299, 449)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Telefono"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 449)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Dueño"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 422)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Licencia Numero"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(299, 395)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 395)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Operador"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 368)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Placas de Jaula"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 341)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Placas de Tractor"
        '
        'TbCelular
        '
        Me.TbCelular.Location = New System.Drawing.Point(374, 554)
        Me.TbCelular.Name = "TbCelular"
        Me.TbCelular.Size = New System.Drawing.Size(148, 20)
        Me.TbCelular.TabIndex = 37
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(116, 554)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(177, 20)
        Me.TbTelefono.TabIndex = 36
        '
        'TbAgenciaAduanal
        '
        Me.TbAgenciaAduanal.Location = New System.Drawing.Point(116, 527)
        Me.TbAgenciaAduanal.Name = "TbAgenciaAduanal"
        Me.TbAgenciaAduanal.Size = New System.Drawing.Size(406, 20)
        Me.TbAgenciaAduanal.TabIndex = 35
        '
        'TbAnticipo
        '
        Me.TbAnticipo.Location = New System.Drawing.Point(116, 500)
        Me.TbAnticipo.Name = "TbAnticipo"
        Me.TbAnticipo.Size = New System.Drawing.Size(177, 20)
        Me.TbAnticipo.TabIndex = 34
        '
        'TbDescuentoFlete
        '
        Me.TbDescuentoFlete.Location = New System.Drawing.Point(374, 472)
        Me.TbDescuentoFlete.Name = "TbDescuentoFlete"
        Me.TbDescuentoFlete.Size = New System.Drawing.Size(148, 20)
        Me.TbDescuentoFlete.TabIndex = 33
        '
        'TbFlete
        '
        Me.TbFlete.Location = New System.Drawing.Point(116, 473)
        Me.TbFlete.Name = "TbFlete"
        Me.TbFlete.Size = New System.Drawing.Size(177, 20)
        Me.TbFlete.TabIndex = 32
        '
        'TbTelefonoDueno
        '
        Me.TbTelefonoDueno.Location = New System.Drawing.Point(374, 446)
        Me.TbTelefonoDueno.Name = "TbTelefonoDueno"
        Me.TbTelefonoDueno.Size = New System.Drawing.Size(148, 20)
        Me.TbTelefonoDueno.TabIndex = 31
        '
        'TbDueno
        '
        Me.TbDueno.Location = New System.Drawing.Point(116, 446)
        Me.TbDueno.Name = "TbDueno"
        Me.TbDueno.Size = New System.Drawing.Size(177, 20)
        Me.TbDueno.TabIndex = 30
        '
        'TbNoLicencia
        '
        Me.TbNoLicencia.Location = New System.Drawing.Point(116, 419)
        Me.TbNoLicencia.Name = "TbNoLicencia"
        Me.TbNoLicencia.Size = New System.Drawing.Size(177, 20)
        Me.TbNoLicencia.TabIndex = 29
        '
        'TbTelefonoOperador
        '
        Me.TbTelefonoOperador.Location = New System.Drawing.Point(374, 392)
        Me.TbTelefonoOperador.Name = "TbTelefonoOperador"
        Me.TbTelefonoOperador.Size = New System.Drawing.Size(148, 20)
        Me.TbTelefonoOperador.TabIndex = 28
        '
        'TbOperador
        '
        Me.TbOperador.Location = New System.Drawing.Point(116, 392)
        Me.TbOperador.Name = "TbOperador"
        Me.TbOperador.Size = New System.Drawing.Size(177, 20)
        Me.TbOperador.TabIndex = 27
        '
        'TbPlacasJaula
        '
        Me.TbPlacasJaula.Location = New System.Drawing.Point(116, 365)
        Me.TbPlacasJaula.Name = "TbPlacasJaula"
        Me.TbPlacasJaula.Size = New System.Drawing.Size(177, 20)
        Me.TbPlacasJaula.TabIndex = 26
        '
        'TbPlacasTractor
        '
        Me.TbPlacasTractor.Location = New System.Drawing.Point(116, 338)
        Me.TbPlacasTractor.Name = "TbPlacasTractor"
        Me.TbPlacasTractor.Size = New System.Drawing.Size(177, 20)
        Me.TbPlacasTractor.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "No. de Serie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Año"
        '
        'TbNoSerie
        '
        Me.TbNoSerie.Location = New System.Drawing.Point(374, 310)
        Me.TbNoSerie.Name = "TbNoSerie"
        Me.TbNoSerie.Size = New System.Drawing.Size(148, 20)
        Me.TbNoSerie.TabIndex = 22
        '
        'TbAnio
        '
        Me.TbAnio.Location = New System.Drawing.Point(116, 311)
        Me.TbAnio.Name = "TbAnio"
        Me.TbAnio.Size = New System.Drawing.Size(177, 20)
        Me.TbAnio.TabIndex = 21
        '
        'TbNoMotor
        '
        Me.TbNoMotor.Location = New System.Drawing.Point(374, 283)
        Me.TbNoMotor.Name = "TbNoMotor"
        Me.TbNoMotor.Size = New System.Drawing.Size(148, 20)
        Me.TbNoMotor.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "No. de Motor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Color"
        '
        'TbColor
        '
        Me.TbColor.Location = New System.Drawing.Point(116, 284)
        Me.TbColor.Name = "TbColor"
        Me.TbColor.Size = New System.Drawing.Size(177, 20)
        Me.TbColor.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Camion Marca"
        '
        'TbMarca
        '
        Me.TbMarca.Location = New System.Drawing.Point(116, 257)
        Me.TbMarca.Name = "TbMarca"
        Me.TbMarca.Size = New System.Drawing.Size(406, 20)
        Me.TbMarca.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Guia No."
        '
        'TbNoGuia
        '
        Me.TbNoGuia.Location = New System.Drawing.Point(116, 230)
        Me.TbNoGuia.Name = "TbNoGuia"
        Me.TbNoGuia.Size = New System.Drawing.Size(177, 20)
        Me.TbNoGuia.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Linea de Transporte"
        '
        'TbLineaTransporte
        '
        Me.TbLineaTransporte.Location = New System.Drawing.Point(116, 203)
        Me.TbLineaTransporte.Name = "TbLineaTransporte"
        Me.TbLineaTransporte.Size = New System.Drawing.Size(406, 20)
        Me.TbLineaTransporte.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Observaciones"
        '
        'TbObservaciones
        '
        Me.TbObservaciones.Location = New System.Drawing.Point(116, 128)
        Me.TbObservaciones.Multiline = True
        Me.TbObservaciones.Name = "TbObservaciones"
        Me.TbObservaciones.Size = New System.Drawing.Size(406, 68)
        Me.TbObservaciones.TabIndex = 9
        '
        'CbSandia
        '
        Me.CbSandia.FormattingEnabled = True
        Me.CbSandia.Location = New System.Drawing.Point(302, 101)
        Me.CbSandia.Name = "CbSandia"
        Me.CbSandia.Size = New System.Drawing.Size(178, 21)
        Me.CbSandia.TabIndex = 8
        '
        'TbPeso
        '
        Me.TbPeso.Location = New System.Drawing.Point(116, 101)
        Me.TbPeso.Name = "TbPeso"
        Me.TbPeso.Size = New System.Drawing.Size(121, 20)
        Me.TbPeso.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
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
        Me.CbAgricultores.Size = New System.Drawing.Size(121, 21)
        Me.CbAgricultores.TabIndex = 4
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
        Me.GbFiltros.Size = New System.Drawing.Size(632, 583)
        Me.GbFiltros.TabIndex = 56
        Me.GbFiltros.TabStop = False
        Me.GbFiltros.Text = "Filtros"
        '
        'DgvEmbarques
        '
        Me.DgvEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmbarques.Location = New System.Drawing.Point(10, 100)
        Me.DgvEmbarques.Name = "DgvEmbarques"
        Me.DgvEmbarques.Size = New System.Drawing.Size(616, 474)
        Me.DgvEmbarques.TabIndex = 56
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
        'Embarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 622)
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
    Friend WithEvents DgvEmbarques As DataGridView
    Friend WithEvents BtFiltrar As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents CbSandiaFiltro As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents DtpFechaFin As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
End Class
