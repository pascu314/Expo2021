Public Class FrmFifo
    Dim time1 As String
    Private Sub BtnVolverFIFO_Click(sender As Object, e As EventArgs) Handles BtnVolverFIFO.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnIngresarFIFO_Click(sender As Object, e As EventArgs) Handles BtnIngresarFIFO.Click
        'ingreso de datos
        If TbProcesosFIFO.Text = "" Or TbTiempo.Text = "" Then
            MsgBox("COMPLETE LOS ESPACIOS VACIOS")
            TbProcesosFIFO.Text = ""
            TbTiempo.Text = ""
        Else 'completar con los tiempos
            If proceso1.Text = "" And tiempo1.Text = "" Then
                proceso1.Text = TbProcesosFIFO.Text
                tiempo1.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And tiempo1 IsNot "" And proceso2.Text = "" And tiempo2.Text = "" Then
                proceso2.Text = TbProcesosFIFO.Text
                tiempo2.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text = "" Then
                proceso3.Text = TbProcesosFIFO.Text
                tiempo3.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text = "" Then
                proceso4.Text = TbProcesosFIFO.Text
                tiempo4.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text = "" Then
                proceso5.Text = TbProcesosFIFO.Text
                tiempo5.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text = "" Then
                proceso6.Text = TbProcesosFIFO.Text
                tiempo6.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text = "" Then
                proceso7.Text = TbProcesosFIFO.Text
                tiempo7.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text = "" Then
                proceso8.Text = TbProcesosFIFO.Text
                tiempo8.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text = "" Then
                proceso9.Text = TbProcesosFIFO.Text
                tiempo9.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            ElseIf proceso1.Text IsNot "" And proceso2.Text IsNot "" And proceso3.Text IsNot "" And proceso4.Text IsNot "" And proceso5.Text IsNot "" And proceso6.Text IsNot "" And proceso7.Text IsNot "" And proceso8.Text IsNot "" And proceso9.Text IsNot "" And proceso10.Text = "" Then
                proceso10.Text = TbProcesosFIFO.Text
                tiempo10.Text = TbTiempo.Text
                TbProcesosFIFO.Text = ""
                TbTiempo.Text = ""
            End If
        End If
    End Sub

    Private Sub TbTiempo_TextChanged(sender As Object, e As EventArgs) Handles TbTiempo.TextChanged
        Dim numero As Integer
        Dim Tiempo As String
        Tiempo = TbTiempo.Text
        numero = IsNumeric(Tiempo)
        If numero = False Then
            TbTiempo.Text = ""
            'no se pueden ingresar letras en el tiempo
        End If
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If proceso1.Text = "" Then
            procesofin1.Text = ""
        ElseIf proceso1.Text IsNot "" Then
            procesofin1.Text = proceso1.Text & " - " & tiempo1.Text
        End If
        If proceso2.Text = "" Then
            procesofin2.Text = ""
        ElseIf proceso2.Text IsNot "" Then
            procesofin2.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso3.Text = "" Then
            procesofin3.Text = ""
        ElseIf proceso3.Text IsNot "" Then
            procesofin3.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso4.Text = "" Then
            procesofin4.Text = ""
        ElseIf proceso4.Text IsNot "" Then
            procesofin4.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso5.Text = "" Then
            procesofin5.Text = ""
        ElseIf proceso5.Text IsNot "" Then
            procesofin5.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso6.Text = "" Then
            procesofin6.Text = ""
        ElseIf proceso6.Text IsNot "" Then
            procesofin6.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso7.Text = "" Then
            procesofin7.Text = ""
        ElseIf proceso7.Text IsNot "" Then
            procesofin7.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso8.Text = "" Then
            procesofin8.Text = ""
        ElseIf proceso8.Text IsNot "" Then
            procesofin8.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso9.Text = "" Then
            procesofin9.Text = ""
        ElseIf proceso9.Text IsNot "" Then
            procesofin9.Text = proceso2.Text & " - " & tiempo2.Text
        End If
        If proceso10.Text = "" Then
            procesofin10.Text = ""
        ElseIf proceso10.Text IsNot "" Then
            procesofin10.Text = proceso2.Text & " - " & tiempo2.Text
        End If
    End Sub

    Private Sub FrmFifo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        proceso1.Text = ""
        proceso2.Text = ""
        proceso3.Text = ""
        proceso4.Text = ""
        proceso5.Text = ""
        proceso6.Text = ""
        proceso7.Text = ""
        proceso8.Text = ""
        proceso9.Text = ""
        proceso10.Text = ""
        tiempo1.Text = ""
        tiempo2.Text = ""
        tiempo3.Text = ""
        tiempo4.Text = ""
        tiempo5.Text = ""
        tiempo6.Text = ""
        tiempo7.Text = ""
        tiempo8.Text = ""
        tiempo9.Text = ""
        tiempo10.Text = ""
        procesofin1.Text = ""
        procesofin2.Text = ""
        procesofin3.Text = ""
        procesofin4.Text = ""
        procesofin5.Text = ""
        procesofin6.Text = ""
        procesofin7.Text = ""
        procesofin8.Text = ""
        procesofin9.Text = ""
        procesofin10.Text = ""
    End Sub
End Class