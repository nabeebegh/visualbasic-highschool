Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim male As String = TextBox1.Text
        Dim female As String = TextBox2.Text
        Randomize(CInt(Int((100 * Rnd()) + 1)))
        Dim rng = CInt(Int((100 * Rnd()) + 1))
        Dim calc = "The chances of " + CStr(male) + " and " + CStr(female) + " having a successful relationship is " + CStr(rng) + "%."
        If (male = "canucks") And (female = "stanley cup") Then
            rng = 100
        End If
        MsgBox(calc)
    End Sub
End Class
