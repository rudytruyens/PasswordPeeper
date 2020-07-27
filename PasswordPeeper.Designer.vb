<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordPeeper
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordPeeper))
        Me.lbl_handle = New System.Windows.Forms.Label()
        Me.tmrCheckMouse = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.lbl_mouse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_handle
        '
        Me.lbl_handle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_handle.Location = New System.Drawing.Point(0, 28)
        Me.lbl_handle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_handle.Name = "lbl_handle"
        Me.lbl_handle.Size = New System.Drawing.Size(493, 21)
        Me.lbl_handle.TabIndex = 0
        '
        'tmrCheckMouse
        '
        Me.tmrCheckMouse.Enabled = True
        Me.tmrCheckMouse.Interval = 200
        '
        'lbl_text
        '
        Me.lbl_text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_text.Location = New System.Drawing.Point(0, 49)
        Me.lbl_text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(493, 21)
        Me.lbl_text.TabIndex = 1
        '
        'lbl_mouse
        '
        Me.lbl_mouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mouse.Location = New System.Drawing.Point(0, 7)
        Me.lbl_mouse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mouse.Name = "lbl_mouse"
        Me.lbl_mouse.Size = New System.Drawing.Size(493, 21)
        Me.lbl_mouse.TabIndex = 2
        Me.lbl_mouse.Text = "Mouse position"
        '
        'PasswordPeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 77)
        Me.Controls.Add(Me.lbl_mouse)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.lbl_handle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PasswordPeeper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PasswordPeeper"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_handle As System.Windows.Forms.Label
    Friend WithEvents tmrCheckMouse As System.Windows.Forms.Timer
    Friend WithEvents lbl_text As Label
    Friend WithEvents lbl_mouse As Label
End Class
