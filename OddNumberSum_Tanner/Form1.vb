Public Class Form1

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim lngSum As Long = 0
        Dim intNumber As Integer = Val(Me.txtNumber.Text)

        Dim intC As Integer
        For intC = 1 To intNumber
            If intC Mod 2 <> 0 Then
                lngSum = lngSum + intC
            End If
        Next intC
        Me.lblSum.Text = "The sum of the numbers between 1 and " & intNumber & " is " & lngSum
    End Sub
    Private Sub btnSum_TextChanged(sender As Object, e As EventArgs) Handles btnSum.TextChanged
        Me.lblSum.Text = Nothing
    End Sub
End Class
