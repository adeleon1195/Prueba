Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Conexion

    Private Sub Conecction()
        Dim con As SqlConnection
        con = New SqlConnection()

        con.ConnectionString = "Database=PRUEBA;Data Source=DESKTOP-QC8BFRH;User Id=UserPrueba;Password=123456"

        Try 'Tratamiento de errores
            con.Open()

            MessageBox.Show("Conexión correcta")

            con.Close()

        Catch mirror As SqlException

            MessageBox.Show("Conexión fallida")

        Finally
            con.Dispose()

        End Try
    End Sub

End Class
