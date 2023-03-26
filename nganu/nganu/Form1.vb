Public Class Form1
    Dim i As Integer
    Dim n As Integer
    Dim p As Integer
    Dim z As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim barang As String
        Dim jumlah As Integer
        Dim harga As Integer
        Dim total As Integer
        'PROSES
        barang = TextBox1.Text
        GroupBox6.Text = barang
        'JUMLAH DAN HARGA DI KALI
        total = TextBox2.Text * TextBox4.Text
        Label3.Text = total
        'AMOUNT
        jumlah = TextBox4.Text
        Label7.Text = jumlah

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = ""
        Label7.Text = ""
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
