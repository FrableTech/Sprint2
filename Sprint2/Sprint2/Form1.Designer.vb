<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sprint2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sprint2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txb1level1 = New System.Windows.Forms.ListBox()
        Me.txb1level3 = New System.Windows.Forms.ListBox()
        Me.txb1level2 = New System.Windows.Forms.ListBox()
        Me.lblLevel3 = New System.Windows.Forms.Label()
        Me.lblLevel2 = New System.Windows.Forms.Label()
        Me.lblLevel1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.tbxName1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txb2effect3 = New System.Windows.Forms.ListBox()
        Me.txb2effect2 = New System.Windows.Forms.ListBox()
        Me.txb2effect1 = New System.Windows.Forms.ListBox()
        Me.lbl2Effect3 = New System.Windows.Forms.Label()
        Me.lbl2Effect2 = New System.Windows.Forms.Label()
        Me.lbl2Effect1 = New System.Windows.Forms.Label()
        Me.lblChoiceName = New System.Windows.Forms.Label()
        Me.tbxName2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txb3effect3 = New System.Windows.Forms.ListBox()
        Me.txb3effect2 = New System.Windows.Forms.ListBox()
        Me.txb3effect1 = New System.Windows.Forms.ListBox()
        Me.lbl3Effect3 = New System.Windows.Forms.Label()
        Me.lbl3Effect2 = New System.Windows.Forms.Label()
        Me.lbl3Effect1 = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.tbxName3 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbxShowHideInfo = New System.Windows.Forms.CheckBox()
        Me.progressBarStim = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStimulate = New System.Windows.Forms.Button()
        Me.lsbStudentAction = New System.Windows.Forms.ListBox()
        Me.lsbEnviromentAction = New System.Windows.Forms.ListBox()
        Me.lblStudentAction = New System.Windows.Forms.Label()
        Me.lblEnviromentAction = New System.Windows.Forms.Label()
        Me.txbStep = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txb1level1)
        Me.GroupBox1.Controls.Add(Me.txb1level3)
        Me.GroupBox1.Controls.Add(Me.txb1level2)
        Me.GroupBox1.Controls.Add(Me.lblLevel3)
        Me.GroupBox1.Controls.Add(Me.lblLevel2)
        Me.GroupBox1.Controls.Add(Me.lblLevel1)
        Me.GroupBox1.Controls.Add(Me.lblName1)
        Me.GroupBox1.Controls.Add(Me.tbxName1)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'txb1level1
        '
        Me.txb1level1.FormattingEnabled = True
        Me.txb1level1.ItemHeight = 16
        Me.txb1level1.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb1level1.Location = New System.Drawing.Point(594, 92)
        Me.txb1level1.Name = "txb1level1"
        Me.txb1level1.Size = New System.Drawing.Size(101, 36)
        Me.txb1level1.TabIndex = 15
        '
        'txb1level3
        '
        Me.txb1level3.FormattingEnabled = True
        Me.txb1level3.ItemHeight = 16
        Me.txb1level3.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb1level3.Location = New System.Drawing.Point(594, 181)
        Me.txb1level3.Name = "txb1level3"
        Me.txb1level3.Size = New System.Drawing.Size(101, 36)
        Me.txb1level3.TabIndex = 14
        '
        'txb1level2
        '
        Me.txb1level2.FormattingEnabled = True
        Me.txb1level2.ItemHeight = 16
        Me.txb1level2.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb1level2.Location = New System.Drawing.Point(594, 138)
        Me.txb1level2.Name = "txb1level2"
        Me.txb1level2.Size = New System.Drawing.Size(101, 36)
        Me.txb1level2.TabIndex = 13
        '
        'lblLevel3
        '
        Me.lblLevel3.AutoSize = True
        Me.lblLevel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLevel3.Location = New System.Drawing.Point(26, 181)
        Me.lblLevel3.Name = "lblLevel3"
        Me.lblLevel3.Size = New System.Drawing.Size(167, 16)
        Me.lblLevel3.TabIndex = 7
        Me.lblLevel3.Text = "Socialization Satisfication Level"
        '
        'lblLevel2
        '
        Me.lblLevel2.AutoSize = True
        Me.lblLevel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLevel2.Location = New System.Drawing.Point(26, 138)
        Me.lblLevel2.Name = "lblLevel2"
        Me.lblLevel2.Size = New System.Drawing.Size(219, 16)
        Me.lblLevel2.TabIndex = 6
        Me.lblLevel2.Text = "Acedemic Performance Satisfication Level"
        '
        'lblLevel1
        '
        Me.lblLevel1.AutoSize = True
        Me.lblLevel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLevel1.Location = New System.Drawing.Point(26, 103)
        Me.lblLevel1.Name = "lblLevel1"
        Me.lblLevel1.Size = New System.Drawing.Size(177, 16)
        Me.lblLevel1.TabIndex = 5
        Me.lblLevel1.Text = "Physical Fitness Satification Level"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblName1.Location = New System.Drawing.Point(26, 37)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(38, 16)
        Me.lblName1.TabIndex = 4
        Me.lblName1.Text = "Name"
        '
        'tbxName1
        '
        Me.tbxName1.Location = New System.Drawing.Point(417, 31)
        Me.tbxName1.Name = "tbxName1"
        Me.tbxName1.Size = New System.Drawing.Size(278, 22)
        Me.tbxName1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txb2effect3)
        Me.GroupBox2.Controls.Add(Me.txb2effect2)
        Me.GroupBox2.Controls.Add(Me.txb2effect1)
        Me.GroupBox2.Controls.Add(Me.lbl2Effect3)
        Me.GroupBox2.Controls.Add(Me.lbl2Effect2)
        Me.GroupBox2.Controls.Add(Me.lbl2Effect1)
        Me.GroupBox2.Controls.Add(Me.lblChoiceName)
        Me.GroupBox2.Controls.Add(Me.tbxName2)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choice Details"
        '
        'txb2effect3
        '
        Me.txb2effect3.FormattingEnabled = True
        Me.txb2effect3.ItemHeight = 16
        Me.txb2effect3.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb2effect3.Location = New System.Drawing.Point(594, 167)
        Me.txb2effect3.Name = "txb2effect3"
        Me.txb2effect3.Size = New System.Drawing.Size(101, 36)
        Me.txb2effect3.TabIndex = 14
        '
        'txb2effect2
        '
        Me.txb2effect2.FormattingEnabled = True
        Me.txb2effect2.ItemHeight = 16
        Me.txb2effect2.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb2effect2.Location = New System.Drawing.Point(594, 125)
        Me.txb2effect2.Name = "txb2effect2"
        Me.txb2effect2.Size = New System.Drawing.Size(101, 36)
        Me.txb2effect2.TabIndex = 13
        '
        'txb2effect1
        '
        Me.txb2effect1.FormattingEnabled = True
        Me.txb2effect1.ItemHeight = 16
        Me.txb2effect1.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb2effect1.Location = New System.Drawing.Point(594, 83)
        Me.txb2effect1.Name = "txb2effect1"
        Me.txb2effect1.Size = New System.Drawing.Size(101, 36)
        Me.txb2effect1.TabIndex = 12
        '
        'lbl2Effect3
        '
        Me.lbl2Effect3.AutoSize = True
        Me.lbl2Effect3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl2Effect3.Location = New System.Drawing.Point(24, 167)
        Me.lbl2Effect3.Name = "lbl2Effect3"
        Me.lbl2Effect3.Size = New System.Drawing.Size(172, 16)
        Me.lbl2Effect3.TabIndex = 11
        Me.lbl2Effect3.Text = "Socializatioin Satisfication Effect"
        '
        'lbl2Effect2
        '
        Me.lbl2Effect2.AutoSize = True
        Me.lbl2Effect2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl2Effect2.Location = New System.Drawing.Point(24, 131)
        Me.lbl2Effect2.Name = "lbl2Effect2"
        Me.lbl2Effect2.Size = New System.Drawing.Size(221, 16)
        Me.lbl2Effect2.TabIndex = 10
        Me.lbl2Effect2.Text = "Acedemic Performance Satisfication Effect"
        '
        'lbl2Effect1
        '
        Me.lbl2Effect1.AutoSize = True
        Me.lbl2Effect1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl2Effect1.Location = New System.Drawing.Point(24, 92)
        Me.lbl2Effect1.Name = "lbl2Effect1"
        Me.lbl2Effect1.Size = New System.Drawing.Size(178, 16)
        Me.lbl2Effect1.TabIndex = 9
        Me.lbl2Effect1.Text = "Psyical Fitness Satisfication Effect"
        '
        'lblChoiceName
        '
        Me.lblChoiceName.AutoSize = True
        Me.lblChoiceName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblChoiceName.Location = New System.Drawing.Point(24, 40)
        Me.lblChoiceName.Name = "lblChoiceName"
        Me.lblChoiceName.Size = New System.Drawing.Size(75, 16)
        Me.lblChoiceName.TabIndex = 8
        Me.lblChoiceName.Text = "Choice Name"
        '
        'tbxName2
        '
        Me.tbxName2.Location = New System.Drawing.Point(417, 40)
        Me.tbxName2.Name = "tbxName2"
        Me.tbxName2.Size = New System.Drawing.Size(278, 22)
        Me.tbxName2.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txb3effect3)
        Me.GroupBox3.Controls.Add(Me.txb3effect2)
        Me.GroupBox3.Controls.Add(Me.txb3effect1)
        Me.GroupBox3.Controls.Add(Me.lbl3Effect3)
        Me.GroupBox3.Controls.Add(Me.lbl3Effect2)
        Me.GroupBox3.Controls.Add(Me.lbl3Effect1)
        Me.GroupBox3.Controls.Add(Me.lblEventName)
        Me.GroupBox3.Controls.Add(Me.tbxName3)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 574)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 232)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enviroment Details"
        '
        'txb3effect3
        '
        Me.txb3effect3.FormattingEnabled = True
        Me.txb3effect3.ItemHeight = 16
        Me.txb3effect3.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb3effect3.Location = New System.Drawing.Point(594, 184)
        Me.txb3effect3.Name = "txb3effect3"
        Me.txb3effect3.Size = New System.Drawing.Size(101, 36)
        Me.txb3effect3.TabIndex = 10
        '
        'txb3effect2
        '
        Me.txb3effect2.FormattingEnabled = True
        Me.txb3effect2.ItemHeight = 16
        Me.txb3effect2.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb3effect2.Location = New System.Drawing.Point(594, 142)
        Me.txb3effect2.Name = "txb3effect2"
        Me.txb3effect2.Size = New System.Drawing.Size(101, 36)
        Me.txb3effect2.TabIndex = 9
        '
        'txb3effect1
        '
        Me.txb3effect1.FormattingEnabled = True
        Me.txb3effect1.ItemHeight = 16
        Me.txb3effect1.Items.AddRange(New Object() {"-1.0", "-.9", "-.8", "-.7", "-.6", "-.5", "-.4", "-.3", "-.2", "-.1", "0", ".1", ".2", ".3", ".4", ".5", ".6", ".7", ".8", ".9", "1.0"})
        Me.txb3effect1.Location = New System.Drawing.Point(594, 100)
        Me.txb3effect1.Name = "txb3effect1"
        Me.txb3effect1.Size = New System.Drawing.Size(101, 36)
        Me.txb3effect1.TabIndex = 8
        '
        'lbl3Effect3
        '
        Me.lbl3Effect3.AutoSize = True
        Me.lbl3Effect3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl3Effect3.Location = New System.Drawing.Point(38, 184)
        Me.lbl3Effect3.Name = "lbl3Effect3"
        Me.lbl3Effect3.Size = New System.Drawing.Size(164, 16)
        Me.lbl3Effect3.TabIndex = 7
        Me.lbl3Effect3.Text = "Socialization Satification Effect"
        '
        'lbl3Effect2
        '
        Me.lbl3Effect2.AutoSize = True
        Me.lbl3Effect2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl3Effect2.Location = New System.Drawing.Point(34, 145)
        Me.lbl3Effect2.Name = "lbl3Effect2"
        Me.lbl3Effect2.Size = New System.Drawing.Size(221, 16)
        Me.lbl3Effect2.TabIndex = 6
        Me.lbl3Effect2.Text = "Acedemic Performance Satisfication Effect"
        '
        'lbl3Effect1
        '
        Me.lbl3Effect1.AutoSize = True
        Me.lbl3Effect1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl3Effect1.Location = New System.Drawing.Point(34, 105)
        Me.lbl3Effect1.Name = "lbl3Effect1"
        Me.lbl3Effect1.Size = New System.Drawing.Size(179, 16)
        Me.lbl3Effect1.TabIndex = 5
        Me.lbl3Effect1.Text = "Physical Fitness Satification Effect"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEventName.Location = New System.Drawing.Point(34, 55)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(69, 16)
        Me.lblEventName.TabIndex = 4
        Me.lblEventName.Text = "Event Name"
        '
        'tbxName3
        '
        Me.tbxName3.Location = New System.Drawing.Point(417, 49)
        Me.tbxName3.Name = "tbxName3"
        Me.tbxName3.Size = New System.Drawing.Size(278, 22)
        Me.tbxName3.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancel.Location = New System.Drawing.Point(1116, 759)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 47)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(1001, 759)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 47)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbxShowHideInfo
        '
        Me.cbxShowHideInfo.AutoSize = True
        Me.cbxShowHideInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxShowHideInfo.Location = New System.Drawing.Point(1054, 12)
        Me.cbxShowHideInfo.Name = "cbxShowHideInfo"
        Me.cbxShowHideInfo.Size = New System.Drawing.Size(118, 20)
        Me.cbxShowHideInfo.TabIndex = 5
        Me.cbxShowHideInfo.Text = "Show/Hide About"
        Me.cbxShowHideInfo.UseVisualStyleBackColor = True
        '
        'progressBarStim
        '
        Me.progressBarStim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.progressBarStim.Location = New System.Drawing.Point(817, 74)
        Me.progressBarStim.Name = "progressBarStim"
        Me.progressBarStim.Size = New System.Drawing.Size(146, 37)
        Me.progressBarStim.TabIndex = 6
        Me.progressBarStim.Value = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(837, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Simulation Progress"
        '
        'btnStimulate
        '
        Me.btnStimulate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStimulate.Location = New System.Drawing.Point(817, 117)
        Me.btnStimulate.Name = "btnStimulate"
        Me.btnStimulate.Size = New System.Drawing.Size(146, 47)
        Me.btnStimulate.TabIndex = 8
        Me.btnStimulate.Text = "&Stimulate"
        Me.btnStimulate.UseVisualStyleBackColor = True
        '
        'lsbStudentAction
        '
        Me.lsbStudentAction.FormattingEnabled = True
        Me.lsbStudentAction.ItemHeight = 16
        Me.lsbStudentAction.Location = New System.Drawing.Point(757, 331)
        Me.lsbStudentAction.Name = "lsbStudentAction"
        Me.lsbStudentAction.Size = New System.Drawing.Size(214, 292)
        Me.lsbStudentAction.TabIndex = 9
        '
        'lsbEnviromentAction
        '
        Me.lsbEnviromentAction.FormattingEnabled = True
        Me.lsbEnviromentAction.ItemHeight = 16
        Me.lsbEnviromentAction.Location = New System.Drawing.Point(1011, 331)
        Me.lsbEnviromentAction.Name = "lsbEnviromentAction"
        Me.lsbEnviromentAction.Size = New System.Drawing.Size(214, 292)
        Me.lsbEnviromentAction.TabIndex = 10
        '
        'lblStudentAction
        '
        Me.lblStudentAction.AutoSize = True
        Me.lblStudentAction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStudentAction.Location = New System.Drawing.Point(814, 312)
        Me.lblStudentAction.Name = "lblStudentAction"
        Me.lblStudentAction.Size = New System.Drawing.Size(87, 16)
        Me.lblStudentAction.TabIndex = 11
        Me.lblStudentAction.Text = "Student Actions"
        '
        'lblEnviromentAction
        '
        Me.lblEnviromentAction.AutoSize = True
        Me.lblEnviromentAction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEnviromentAction.Location = New System.Drawing.Point(1064, 312)
        Me.lblEnviromentAction.Name = "lblEnviromentAction"
        Me.lblEnviromentAction.Size = New System.Drawing.Size(108, 16)
        Me.lblEnviromentAction.TabIndex = 12
        Me.lblEnviromentAction.Text = "Enviroment Actions"
        '
        'txbStep
        '
        Me.txbStep.Location = New System.Drawing.Point(969, 89)
        Me.txbStep.Name = "txbStep"
        Me.txbStep.Size = New System.Drawing.Size(36, 22)
        Me.txbStep.TabIndex = 13
        Me.txbStep.Text = "Steps"
        '
        'Sprint2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1332, 823)
        Me.Controls.Add(Me.txbStep)
        Me.Controls.Add(Me.lblEnviromentAction)
        Me.Controls.Add(Me.lblStudentAction)
        Me.Controls.Add(Me.lsbEnviromentAction)
        Me.Controls.Add(Me.lsbStudentAction)
        Me.Controls.Add(Me.btnStimulate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.progressBarStim)
        Me.Controls.Add(Me.cbxShowHideInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sprint2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sprint2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbxShowHideInfo As CheckBox
    Friend WithEvents progressBarStim As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStimulate As Button
    Friend WithEvents lsbStudentAction As ListBox
    Friend WithEvents lsbEnviromentAction As ListBox
    Friend WithEvents lblStudentAction As Label
    Friend WithEvents lblEnviromentAction As Label
    Friend WithEvents tbxName1 As TextBox
    Friend WithEvents tbxName2 As TextBox
    Friend WithEvents tbxName3 As TextBox
    Friend WithEvents lblLevel3 As Label
    Friend WithEvents lblLevel2 As Label
    Friend WithEvents lblLevel1 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents lbl2Effect3 As Label
    Friend WithEvents lbl2Effect2 As Label
    Friend WithEvents lbl2Effect1 As Label
    Friend WithEvents lblChoiceName As Label
    Friend WithEvents lbl3Effect3 As Label
    Friend WithEvents lbl3Effect2 As Label
    Friend WithEvents lbl3Effect1 As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents txb1level2 As ListBox
    Friend WithEvents txb1level1 As ListBox
    Friend WithEvents txb1level3 As ListBox
    Friend WithEvents txb2effect3 As ListBox
    Friend WithEvents txb2effect2 As ListBox
    Friend WithEvents txb2effect1 As ListBox
    Friend WithEvents txb3effect3 As ListBox
    Friend WithEvents txb3effect2 As ListBox
    Friend WithEvents txb3effect1 As ListBox
    Friend WithEvents txbStep As TextBox
End Class
