Public Class Distancia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value * 1000
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value * 10000
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 3 Then
            Label3.Text = NumericUpDown1.Value * 100000
        End If
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 4 Then
            Label3.Text = NumericUpDown1.Value * 1000000
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 1000
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value * 10
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 3 Then
            Label3.Text = NumericUpDown1.Value * 100
        End If
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 4 Then
            Label3.Text = NumericUpDown1.Value * 1000
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 10000
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value / 10
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 3 Then
            Label3.Text = NumericUpDown1.Value * 10
        End If
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 4 Then
            Label3.Text = NumericUpDown1.Value * 100
        End If
        If ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 100000
        End If
        If ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value / 100
        End If
        If ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value / 10
        End If
        If ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 3 Then
            Label3.Text = NumericUpDown1.Value
        End If
        If ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 4 Then
            Label3.Text = NumericUpDown1.Value * 10
        End If
        If ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 0 Then
            Label3.Text = NumericUpDown1.Value / 1000000
        End If
        If ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 1 Then
            Label3.Text = NumericUpDown1.Value / 1000
        End If
        If ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 2 Then
            Label3.Text = NumericUpDown1.Value / 100
        End If
        If ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 3 Then
            Label3.Text = NumericUpDown1.Value / 10
        End If
        If ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 4 Then
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