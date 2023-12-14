Public Class Form1
    Private Sub btnLLenar_Click(sender As Object, e As EventArgs) Handles btnFillTank1.Click
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnFillTank2_Click(sender As Object, e As EventArgs) Handles btnFillTank2.Click
        Timer2.Enabled = True
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tanque1.Increment(50)
        Label6.Text = Tanque1.Value
        If opcTubAbierta.Checked = True Then
            If Tanque1.Value >= 2105 Then
                Tuberia.Increment(10)
                Tanque2.Increment(100)
                Timer1.Stop()
                Timer2.Start()
                Label14.Text = Tanque2.Value
            End If

        Else
            Label17.Text = "Cerrada"
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Timer1.Interval = HScrollBar1.Value
        Timer2.Interval = HScrollBar1.Value
    End Sub

    Private Sub btnResetTank1_Click(sender As Object, e As EventArgs) Handles btnResetTank1.Click
        Timer1.Stop()
        Timer2.Stop()
        Tanque1.Value = 0
        Tanque2.Value = 0
        Tuberia.Value = 0
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Tanque2.Increment(50)
        Label14.Text = Tanque2.Value
        If opcTubAbierta.Checked = True Then
            Label17.Text = "Abierta"
            If Tanque2.Value >= 3005 Then
                Tuberia.Increment(20)
                Tanque1.Increment(100)
                Label6.Text = Tanque1.Value
                Timer2.Stop()
                Timer1.Start()
            End If

        Else
            Label17.Text = "Cerrada"
        End If
    End Sub

    Private Sub btnResetTank2_Click(sender As Object, e As EventArgs) Handles btnResetTank2.Click
        Timer1.Stop()
        Timer2.Stop()
        Tanque1.Value = 0
        Tanque2.Value = 0
        Tuberia.Value = 0
    End Sub

    Private Sub btnFillBoth_Click(sender As Object, e As EventArgs) Handles btnFillBoth.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub btnStop2_Click(sender As Object, e As EventArgs) Handles btnStop2.Click
        Timer2.Stop()
    End Sub

End Class
