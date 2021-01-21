Public Class CountingNumbers
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userIn As String
        Dim positive As Integer
        Dim negative As Integer
        Dim sum As Integer
        userIn = InputBox("Enter a whole number, positive or negative, but the program ends when you enter the number 0.")
        Do While userIn <> 0
            ListBox1.Items.Add(userIn)
            If userIn Mod 2 = 0 Then
                positive = positive + 1
            Else
                negative = negative + 1
            End If
            sum = sum + CInt(userIn)
            userIn = InputBox("Enter a whole number, positive or negative, but the program ends when you enter the number 0.")
        Loop
        txtPositives.Text = CStr(positive)
        txtNegatives.Text = CStr(negative)
        txtSum.Text = CStr(sum)
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ListBox1.Items.Clear()
        txtSum.Text = ""
        txtNegatives.Text = ""
        txtPositives.Text = ""
    End Sub
End Class
