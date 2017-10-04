<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelloWorld
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
        Me.btnPress = New System.Windows.Forms.Button()
        Me.lstHello = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPress
        '
        Me.btnPress.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPress.ForeColor = System.Drawing.Color.White
        Me.btnPress.Location = New System.Drawing.Point(258, 138)
        Me.btnPress.Name = "btnPress"
        Me.btnPress.Size = New System.Drawing.Size(159, 50)
        Me.btnPress.TabIndex = 0
        Me.btnPress.Text = "Press Me"
        Me.btnPress.UseVisualStyleBackColor = False
        '
        'lstHello
        '
        Me.lstHello.FormattingEnabled = True
        Me.lstHello.Location = New System.Drawing.Point(239, 265)
        Me.lstHello.Name = "lstHello"
        Me.lstHello.Size = New System.Drawing.Size(199, 160)
        Me.lstHello.TabIndex = 1
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(681, 574)
        Me.Controls.Add(Me.lstHello)
        Me.Controls.Add(Me.btnPress)
        Me.Name = "HelloWorld"
        Me.Text = "HelloWorld"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents lstHello As ListBox
End Class
