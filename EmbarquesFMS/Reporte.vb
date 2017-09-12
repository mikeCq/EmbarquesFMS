Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Public Class Reporte
    Dim cnn As New SqlConnection(VarGlob.ConexionPrincipal)
    Dim cmd As SqlCommand
    Private Sub GeneraReporte(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim CrReport As RPTEmbarque = New RPTEmbarque
            If cnn.State <> ConnectionState.Open Then cnn.Open()
            Dim da As New SqlCommand("Sp_ReporteEmbarque", cnn)
            Dim Ruta As String = Application.StartupPath & "\RPT\RPTEmbarque.rpt"
            da.CommandType = CommandType.StoredProcedure
            Dim IdEmbarque As New SqlClient.SqlParameter()
            IdEmbarque.ParameterName = "@idEmbarque"
            IdEmbarque.SqlDbType = SqlDbType.NVarChar
            IdEmbarque.Value = Embarques.codigoEmbarque

            da.Parameters.Add(IdEmbarque)

            Dim Dasp_ReporteEmbarque As New SqlClient.SqlDataAdapter()
            Dasp_ReporteEmbarque.SelectCommand = da
            Dim ds As New DataTable
            Dasp_ReporteEmbarque.Fill(ds)

            CrReport.Load(Ruta)

            CrReport.SetDataSource(ds)

            CrEmbarque.ReportSource = CrReport
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try
    End Sub
End Class