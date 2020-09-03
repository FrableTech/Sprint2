Public Class Sprint2


    Private name1 As String
    Private name2 As String
    Private name3 As String
    Private txb11 As String
    Private txb12 As String
    Private txb13 As String
    Private txb21 As String
    Private txb22 As String
    Private txb23 As String
    Private txb31 As String
    Private txb32 As String
    Private txb33 As String




    Private Sub Sprint2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxName1.TextChanged

        name1 = tbxName1.Text()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb13 = txb1level3.Text()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb12 = txb1level2.Text()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        'stores text box value
        txb11 = txb1level1.Text()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles tbxName2.TextChanged
        'stores text box value
        name2 = tbxName2.Text()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb21 = txb2effect1.Text()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb23 = txb2effect3.Text()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles tbxName3.TextChanged
        'stores text box value
        name3 = tbxName3.Text()

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb31 = txb3effect1.Text()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb22 = txb2effect2.Text()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb32 = txb3effect2.Text()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs)
        'stores text box value
        txb33 = txb3effect3.Text()

    End Sub


    ''' <summary>
    ''' All Private sub labels are labes for windows form
    ''' </summary>




    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblName1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblLevel1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblLevel2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblLevel3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblChoiceName.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl2Effect1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lbl2Effect2.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lbl2Effect3.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblEventName.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lbl3Effect1.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lbl3Effect2.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles lbl3Effect3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes application
        '  MessageBox.Show(name1)
        '    MessageBox.Show(txb11)
        '   MessageBox.Show(txb12)
        '  MessageBox.Show(txb13)
        Me.Close()
    End Sub

    Private Sub F1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode <> Keys.F1 Then
            btnExit.PerformClick()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowHideInfo.CheckedChanged
        'Shows developer information at the toggle of a switch
        MessageBox.Show("Created By:
                        Brian J. Frable. A student at OKlahoma Baptist University.
                        
                        Version 1.0.2
                        CopyRight: JF Dev.")


    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles progressBarStim.Click

    End Sub

    Private Sub Sprint2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'closes application

        Me.Close()
    End Sub

    Private Sub btnStimulate_Click(sender As Object, e As EventArgs) Handles btnStimulate.Click


        Dim i As Double
        'converts string into doubles so that we can wrok with making an function


        'varibles for the average of respected group
        Dim stim1 As Double
        Dim stim2 As Double
        Dim stim3 As Double

        'string varibles
        Dim str11 As Double
        Dim str12 As Double
        Dim str13 As Double
        Dim str21 As Double
        Dim str22 As Double
        Dim str23 As Double
        Dim str31 As Double
        Dim str32 As Double
        Dim str33 As Double


        'conversions to Dbl
        str11 = CDbl(txb11)
        str12 = CDbl(txb12)
        str13 = CDbl(txb13)

        str21 = CDbl(txb21)
        str22 = CDbl(txb22)
        str23 = CDbl(txb33)

        str31 = CDbl(txb31)
        str32 = CDbl(txb32)
        str33 = CDbl(txb33)

        stim1 = (str11 + str12 + str13) / 3
        stim2 = (str21 + str22 + str23) / 3
        stim3 = (str31 + str32 + str33) / 3


        'Dim step As String

        'If i <= 100 Then
        ''i2 is string of step number this loop shows steps
        'Dim i2 As String
        'i2 = CStr(i)
        'i = 1
        'MessageBox.Show("step" + i2)
        'i = i + 1
        'End If

        MessageBox.Show("Student's Health level"(stim1))
    End Sub

    Private Sub txb1level2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txb1level2.SelectedIndexChanged
        txb12 = txb1level2.Text()
    End Sub

    Private Sub txb1level1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txb1level1.SelectedIndexChanged
        txb11 = txb1level1.Text()
    End Sub

    Private Sub txb1level3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txb1level3.SelectedIndexChanged
        txb13 = txb1level3.Text()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lsbStudentAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbStudentAction.SelectedIndexChanged

    End Sub

    Private Sub txbStep_TextChanged(sender As Object, e As EventArgs) Handles txbStep.TextChanged

    End Sub
End Class
