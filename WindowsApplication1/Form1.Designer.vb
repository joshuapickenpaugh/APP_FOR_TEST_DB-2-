<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstBoxFirstNames = New System.Windows.Forms.ListBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lstBoxLastNames = New System.Windows.Forms.ListBox()
        Me.btnClick2 = New System.Windows.Forms.Button()
        Me.lstBoxEmail = New System.Windows.Forms.ListBox()
        Me.btnClick3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxFirstNames
        '
        Me.lstBoxFirstNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxFirstNames.FormattingEnabled = True
        Me.lstBoxFirstNames.ItemHeight = 16
        Me.lstBoxFirstNames.Location = New System.Drawing.Point(13, 13)
        Me.lstBoxFirstNames.Name = "lstBoxFirstNames"
        Me.lstBoxFirstNames.Size = New System.Drawing.Size(265, 84)
        Me.lstBoxFirstNames.TabIndex = 0
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(13, 103)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(265, 39)
        Me.btnClick.TabIndex = 1
        Me.btnClick.Text = "Show First Names"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'lstBoxLastNames
        '
        Me.lstBoxLastNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxLastNames.FormattingEnabled = True
        Me.lstBoxLastNames.ItemHeight = 16
        Me.lstBoxLastNames.Location = New System.Drawing.Point(13, 149)
        Me.lstBoxLastNames.Name = "lstBoxLastNames"
        Me.lstBoxLastNames.Size = New System.Drawing.Size(265, 84)
        Me.lstBoxLastNames.TabIndex = 2
        '
        'btnClick2
        '
        Me.btnClick2.Location = New System.Drawing.Point(13, 238)
        Me.btnClick2.Name = "btnClick2"
        Me.btnClick2.Size = New System.Drawing.Size(265, 39)
        Me.btnClick2.TabIndex = 3
        Me.btnClick2.Text = "Sbow Last Names"
        Me.btnClick2.UseVisualStyleBackColor = True
        '
        'lstBoxEmail
        '
        Me.lstBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxEmail.FormattingEnabled = True
        Me.lstBoxEmail.ItemHeight = 16
        Me.lstBoxEmail.Location = New System.Drawing.Point(13, 284)
        Me.lstBoxEmail.Name = "lstBoxEmail"
        Me.lstBoxEmail.Size = New System.Drawing.Size(265, 84)
        Me.lstBoxEmail.TabIndex = 4
        '
        'btnClick3
        '
        Me.btnClick3.Location = New System.Drawing.Point(13, 372)
        Me.btnClick3.Name = "btnClick3"
        Me.btnClick3.Size = New System.Drawing.Size(265, 39)
        Me.btnClick3.TabIndex = 5
        Me.btnClick3.Text = "Show Email"
        Me.btnClick3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 429)
        Me.Controls.Add(Me.btnClick3)
        Me.Controls.Add(Me.lstBoxEmail)
        Me.Controls.Add(Me.btnClick2)
        Me.Controls.Add(Me.lstBoxLastNames)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lstBoxFirstNames)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxFirstNames As ListBox
    Friend WithEvents btnClick As Button
    Friend WithEvents lstBoxLastNames As ListBox
    Friend WithEvents btnClick2 As Button
    Friend WithEvents lstBoxEmail As ListBox
    Friend WithEvents btnClick3 As Button
End Class
