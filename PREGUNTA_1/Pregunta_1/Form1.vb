Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a >= b Then GoTo amayorb Else GoTo bmayora
        GoTo Salir
amayorb:
        If a >= c Then GoTo amayorc Else GoTo cmayora
        GoTo Salir

amayorc:
        If b >= c Then GoTo bmayorc Else GoTo cmayorb
        GoTo Salir
bmayorc:
        TextBox1.Text = c.ToString()
        TextBox2.Text = b.ToString()
        TextBox3.Text = a.ToString()
        GoTo Salir
cmayorb:
        TextBox1.Text = b.ToString()
        TextBox2.Text = c.ToString()
        TextBox3.Text = a.ToString()
        GoTo Salir
cmayora:
        TextBox1.Text = b.ToString()
        TextBox2.Text = a.ToString()
        TextBox3.Text = c.ToString()
        GoTo Salir
bmayora:
        If b >= c Then GoTo bmayorc1 Else GoTo cmayorb1
        GoTo Salir
cmayorb1:
        TextBox1.Text = a.ToString()
        TextBox2.Text = b.ToString()
        TextBox3.Text = c.ToString()
        GoTo Salir
bmayorc1:
        If a >= c Then GoTo amayorc1 Else GoTo cmayora1
        GoTo Salir
amayorc1:
        TextBox1.Text = c.ToString()
        TextBox2.Text = a.ToString()
        TextBox3.Text = b.ToString()
        GoTo Salir
cmayora1:
        TextBox1.Text = a.ToString()
        TextBox2.Text = c.ToString()
        TextBox3.Text = b.ToString()
        GoTo Salir
Salir:
    End Sub

End Class
