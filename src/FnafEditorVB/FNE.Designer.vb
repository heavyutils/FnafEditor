<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Label2 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        Label1 = New Label()
        Button4 = New Button()
        ButtonOK = New Button()
        NumericUpDown1 = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.Location = New Point(12, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 30)
        Label2.TabIndex = 0
        Label2.Text = "Night:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 12F)
        Button2.Location = New Point(138, 48)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 36)
        Button2.TabIndex = 2
        Button2.Text = "No"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.Location = New Point(12, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 36)
        Label3.TabIndex = 3
        Label3.Text = "Beat Game:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft Sans Serif", 12F)
        Button3.Location = New Point(158, 90)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 36)
        Button3.TabIndex = 4
        Button3.Text = "No"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.Location = New Point(12, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 36)
        Label4.TabIndex = 5
        Label4.Text = "Beat 6th Night:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 12F)
        Label1.Location = New Point(12, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 36)
        Label1.TabIndex = 6
        Label1.Text = "Beat 4/20:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft Sans Serif", 12F)
        Button4.Location = New Point(128, 132)
        Button4.Name = "Button4"
        Button4.Size = New Size(160, 36)
        Button4.TabIndex = 7
        Button4.Text = "No"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ButtonOK
        ' 
        ButtonOK.Font = New Font("Microsoft Sans Serif", 15F)
        ButtonOK.Location = New Point(12, 252)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(276, 36)
        ButtonOK.TabIndex = 8
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Microsoft Sans Serif", 12F)
        NumericUpDown1.Location = New Point(88, 12)
        NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(200, 30)
        NumericUpDown1.TabIndex = 9
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        ' 
        ' FNE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(300, 300)
        Controls.Add(NumericUpDown1)
        Controls.Add(ButtonOK)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FNE"
        ShowIcon = False
        Text = "FnafEditor (fn1)"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
