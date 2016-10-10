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
        Me.lstBoxPersons = New System.Windows.Forms.ListBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxPersons
        '
        Me.lstBoxPersons.FormattingEnabled = True
        Me.lstBoxPersons.Location = New System.Drawing.Point(13, 13)
        Me.lstBoxPersons.Name = "lstBoxPersons"
        Me.lstBoxPersons.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxPersons.TabIndex = 0
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(13, 115)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(120, 23)
        Me.btnClick.TabIndex = 1
        Me.btnClick.Text = "Show Persons"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(147, 156)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lstBoxPersons)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxPersons As ListBox
    Friend WithEvents btnClick As Button
End Class
