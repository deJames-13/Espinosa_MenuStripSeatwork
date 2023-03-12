<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlankPage
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.mainFrame = New System.Windows.Forms.Panel()
        Me.mainFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.BackColor = System.Drawing.Color.Beige
        Me.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(10, 10)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(2)
        Me.panelMain.Size = New System.Drawing.Size(839, 374)
        Me.panelMain.TabIndex = 16
        '
        'mainFrame
        '
        Me.mainFrame.BackColor = System.Drawing.Color.Azure
        Me.mainFrame.Controls.Add(Me.panelMain)
        Me.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainFrame.Location = New System.Drawing.Point(0, 0)
        Me.mainFrame.Name = "mainFrame"
        Me.mainFrame.Padding = New System.Windows.Forms.Padding(10)
        Me.mainFrame.Size = New System.Drawing.Size(859, 394)
        Me.mainFrame.TabIndex = 2
        '
        'BlankPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 394)
        Me.Controls.Add(Me.mainFrame)
        Me.Name = "BlankPage"
        Me.Text = "BlankPage"
        Me.mainFrame.ResumeLayout(False)
        Me.mainFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents mainFrame As Panel
End Class
