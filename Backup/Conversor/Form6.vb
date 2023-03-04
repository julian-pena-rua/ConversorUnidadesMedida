Public Class Moneda

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value * 1.43
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value * 2873.5
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 1.43
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value * 2016.49
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 2873.5
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value / 2016.49
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value
        End If

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        NumericUpDown1.Minimum = 0
        NumericUpDown1.Maximum = 1000000000
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Close()
    End Sub
End Class