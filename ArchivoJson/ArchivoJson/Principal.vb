﻿Imports System.IO

Public Class Principal

    Private Sub SELECCIONAR_Click(sender As Object, e As EventArgs) Handles SELECCIONAR.Click

        Dim rutaDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fileDefault = "Datos.txt"

        Dim abrir As New OpenFileDialog
        abrir.InitialDirectory = rutaDefault
        abrir.Filter = "Archivos Datos|*txt"

        If File.Exists(Path.Combine(rutaDefault, fileDefault)) Then
            'Nombre de archivo que se cargará por defecto, si existe en la ruta
            abrir.FileName = fileDefault
        End If

        If abrir.ShowDialog = DialogResult.OK Then
            TextBox1.Text = abrir.FileName
        End If

    End Sub

    Private Sub VER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VER.Click
        Dim f2 As New VerDatos
        f2.Show()
        Me.Hide()
    End Sub
End Class
