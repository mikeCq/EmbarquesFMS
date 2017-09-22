Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Embarques
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private _codigoEmbarque As Integer
    Dim TablaDatos As DataTable
    Public Property codigoEmbarque() As Integer
        Get
            Return _codigoEmbarque
        End Get
        Set(value As Integer)
            _codigoEmbarque = value
        End Set
    End Property
    Private Sub Embarques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        CargarInfo()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
        CargarInfo()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        If TbIdEmbarque.Text <> "" Then Imprimir(TbIdEmbarque.Text)
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Nuevo()
        TbIdEmbarque.Text = ""
        TbNoFactura.Text = ""
        CbAgricultores.SelectedValue = -1
        TbDireccion.Text = ""
        TbPeso.Text = ""
        CbSandia.SelectedValue = -1
        TbObservaciones.Text = ""
        TbLineaTransporte.Text = ""
        TbNoGuia.Text = ""
        TbMarca.Text = ""
        TbColor.Text = ""
        TbNoMotor.Text = ""
        TbAnio.Text = ""
        TbNoSerie.Text = ""
        TbPlacasTractor.Text = ""
        TbPlacasJaula.Text = ""
        TbOperador.Text = ""
        TbTelefonoOperador.Text = ""
        TbNoLicencia.Text = ""
        TbDueno.Text = ""
        TbTelefonoDueno.Text = ""
        TbFlete.Text = ""
        TbDescuentoFlete.Text = ""
        TbAnticipo.Text = ""
        TbAgenciaAduanal.Text = ""
        TbTelefono.Text = ""
        TbCelular.Text = ""
        GbDatosGenerales.Enabled = True
    End Sub
    Private Sub Guardar()
        Try
            If cnn.State <> ConnectionState.Open Then cnn.Open()
            Dim cmd As New SqlCommand("sp_InsEmb", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdEmbarque", IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)))
            cmd.Parameters.Add(New SqlParameter("@FechaEmbarque", Now))
            cmd.Parameters.Add(New SqlParameter("@NumeroFactura", TbNoFactura.Text))
            cmd.Parameters.Add(New SqlParameter("@NombreAgricultor", CbAgricultores.Text))
            cmd.Parameters.Add(New SqlParameter("@TelefonoAgricultor", TbTelefonoAgricultor.Text))
            cmd.Parameters.Add(New SqlParameter("@Direccion", TbDireccion.Text))
            cmd.Parameters.Add(New SqlParameter("@PesoKgs", CDbl(TbPeso.Text)))
            cmd.Parameters.Add(New SqlParameter("@Tipo", CbSandia.Text))
            cmd.Parameters.Add(New SqlParameter("@Observacion", TbObservaciones.Text))
            cmd.Parameters.Add(New SqlParameter("@LineaTransporte", TbLineaTransporte.Text))
            cmd.Parameters.Add(New SqlParameter("@NumeroGuia", TbNoGuia.Text))
            cmd.Parameters.Add(New SqlParameter("@CamionMarca", TbMarca.Text))
            cmd.Parameters.Add(New SqlParameter("@Color", TbColor.Text))
            cmd.Parameters.Add(New SqlParameter("@NumeroMotor", TbNoMotor.Text))
            cmd.Parameters.Add(New SqlParameter("@Ano", TbAnio.Text))
            cmd.Parameters.Add(New SqlParameter("@NumeroSerie", TbNoSerie.Text))
            cmd.Parameters.Add(New SqlParameter("@PlacasTractor", TbPlacasTractor.Text))
            cmd.Parameters.Add(New SqlParameter("@PlacasJaula", TbPlacasJaula.Text))
            cmd.Parameters.Add(New SqlParameter("@Operador", TbOperador.Text))
            cmd.Parameters.Add(New SqlParameter("@Telefono", TbTelefonoOperador.Text))
            cmd.Parameters.Add(New SqlParameter("@NumeroLicencia", TbNoLicencia.Text))
            cmd.Parameters.Add(New SqlParameter("@Dueno", TbDueno.Text))
            cmd.Parameters.Add(New SqlParameter("@TelefonoDueno", TbTelefonoDueno.Text))
            cmd.Parameters.Add(New SqlParameter("@PagarFlete", CDec(TbFlete.Text)))
            cmd.Parameters.Add(New SqlParameter("@FleteMenos", CDec(TbDescuentoFlete.Text)))
            cmd.Parameters.Add(New SqlParameter("@Anticipo", CDec(TbAnticipo.Text)))
            cmd.Parameters.Add(New SqlParameter("@AgenciaAduanal", TbAgenciaAduanal.Text))
            cmd.Parameters.Add(New SqlParameter("@TelefonoAgencia", TbTelefono.Text))
            cmd.Parameters.Add(New SqlParameter("@CelularAgencia", TbCelular.Text))
            cmd.Parameters("@IdEmbarque").Direction = ParameterDirection.InputOutput
            cmd.ExecuteNonQuery()
            TbIdEmbarque.Text = cmd.Parameters("@IdEmbarque").Value
            cnn.Close()
            Imprimir(TbIdEmbarque.Text)
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.ToString)
        Finally
        End Try
    End Sub
    Private Sub Imprimir(ByVal IdBoleta As Integer)
        _codigoEmbarque = IdBoleta
        Reporte.ShowDialog()
    End Sub
    Private Sub CargarCombos()
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "MIXTA"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "SANGRIA"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Id") = "3"
        dr("Descripcion") = "SEEDLESS"
        dt.Rows.Add(dr)

        CbSandia.DataSource = dt
        CbSandia.ValueMember = "Id"
        CbSandia.DisplayMember = "Descripcion"
        CbSandia.SelectedValue = 1

        'AGRICULTORES
        Dim dt2 As DataTable = New DataTable("Tabla2")

        dt2.Columns.Add("Id")
        dt2.Columns.Add("Descripcion")

        Dim dr2 As DataRow

        dr2 = dt2.NewRow()
        dr2("Id") = "1"
        dr2("Descripcion") = "Peter Heinrichs"
        dt2.Rows.Add(dr2)

        CbAgricultores.DataSource = dt2
        CbAgricultores.ValueMember = "Id"
        CbAgricultores.DisplayMember = "Descripcion"
        CbAgricultores.SelectedValue = 1
    End Sub

    Private Sub CargarInfo()
        If cnn.State <> ConnectionState.Open Then cnn.Open()
        Dim cmd As New SqlCommand("sp_LlenarEmbarques", cnn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DgvEmbarques.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub SeleccionProducto(sender As Object, e As EventArgs) Handles DgvEmbarques.DoubleClick
        If DgvEmbarques.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf Not DgvEmbarques Is Nothing Then
            _codigoEmbarque = CStr(DgvEmbarques.CurrentRow.Cells("IdEmbarque").Value)
            If cnn.State <> ConnectionState.Open Then cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenarFormulario", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@IdEmbarque", _codigoEmbarque))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            TablaDatos = dt
            Dim row As DataRow = TablaDatos.Rows(0)
            TbIdEmbarque.Text = row("IdEmbarque")
            TbNoFactura.Text = row("NumeroFactura")
            CbAgricultores.Text = row("NombreAgricultor")
            TbDireccion.Text = row("Direccion")
            TbTelefonoAgricultor.Text = row("TelefonoAgricultor")
            TbPeso.Text = row("PesoKgs")
            CbSandia.Text = row("Tipo")
            TbObservaciones.Text = row("Observacion")
            TbLineaTransporte.Text = row("LineaTransporte")
            TbNoGuia.Text = row("NumeroGuia")
            TbMarca.Text = row("CamionMarca")
            TbColor.Text = row("Color")
            TbNoMotor.Text = row("NumeroMotor")
            TbAnio.Text = row("Ano")
            TbNoSerie.Text = row("NumeroSerie")
            TbPlacasTractor.Text = row("PlacasTractor")
            TbPlacasJaula.Text = row("PlacasJaula")
            TbOperador.Text = row("Operador")
            TbTelefonoOperador.Text = row("Telefono")
            TbNoLicencia.Text = row("NumeroLicencia")
            TbDueno.Text = row("Dueno")
            TbTelefonoDueno.Text = row("TelefonoDueno")
            TbFlete.Text = row("PagarFlete")
            TbDescuentoFlete.Text = row("FleteMenos")
            TbAnticipo.Text = row("Anticipo")
            TbAgenciaAduanal.Text = row("AgenciaAduanal")
            TbTelefono.Text = row("TelefonoAgencia")
            TbCelular.Text = row("CelularAgencia")
            GbDatosGenerales.Enabled = False
            cnn.Close()
        End If
    End Sub
End Class
