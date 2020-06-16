Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class VerDatos

    Dim dt As DataTable

    Private Sub PRINCIPAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINCIPAL.Click
        Dim f2 As New Principal
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub EMPRESA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPRESA.Click
        ListarEmpresa()
    End Sub

    Private Sub ListarEmpresa()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Empresa", conexion)
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
        Cerrar()

    End Sub

End Class