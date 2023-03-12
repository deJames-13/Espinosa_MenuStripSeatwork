<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.mainFrame = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.menuForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.formMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.formForm2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.formBlank = New System.Windows.Forms.ToolStripMenuItem()
        Me.formsHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainFrame.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.PageContainer.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainFrame
        '
        Me.mainFrame.BackColor = System.Drawing.Color.Azure
        Me.mainFrame.Controls.Add(Me.Panel9)
        Me.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainFrame.Location = New System.Drawing.Point(2, 2)
        Me.mainFrame.Name = "mainFrame"
        Me.mainFrame.Padding = New System.Windows.Forms.Padding(10)
        Me.mainFrame.Size = New System.Drawing.Size(855, 490)
        Me.mainFrame.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Beige
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.PageContainer)
        Me.Panel9.Controls.Add(Me.Panel1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(10, 10)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.Panel9.Size = New System.Drawing.Size(835, 470)
        Me.Panel9.TabIndex = 16
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.Beige
        Me.PageContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PageContainer.Controls.Add(Me.panelMain)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PageContainer.Location = New System.Drawing.Point(10, 70)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.PageContainer.Size = New System.Drawing.Size(815, 385)
        Me.PageContainer.TabIndex = 19
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.BackColor = System.Drawing.Color.Beige
        Me.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.btnForm2)
        Me.panelMain.Controls.Add(Me.btnMain)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(2, 2)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(2)
        Me.panelMain.Size = New System.Drawing.Size(811, 381)
        Me.panelMain.TabIndex = 17
        '
        'btnForm2
        '
        Me.btnForm2.BackColor = System.Drawing.Color.Transparent
        Me.btnForm2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForm2.Location = New System.Drawing.Point(254, 218)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(281, 68)
        Me.btnForm2.TabIndex = 13
        Me.btnForm2.Text = "Form2"
        Me.btnForm2.UseVisualStyleBackColor = False
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Location = New System.Drawing.Point(254, 46)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(281, 68)
        Me.btnMain.TabIndex = 11
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.mainMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(815, 45)
        Me.Panel1.TabIndex = 18
        '
        'mainMenu
        '
        Me.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuForms, Me.menuSettings, Me.HomeToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(2, 2)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(809, 39)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'menuForms
        '
        Me.menuForms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formMain, Me.formForm2, Me.formBlank, Me.formsHome})
        Me.menuForms.Name = "menuForms"
        Me.menuForms.Size = New System.Drawing.Size(52, 35)
        Me.menuForms.Text = "Forms"
        '
        'formMain
        '
        Me.formMain.Name = "formMain"
        Me.formMain.Size = New System.Drawing.Size(108, 22)
        Me.formMain.Text = "Main"
        '
        'formForm2
        '
        Me.formForm2.Name = "formForm2"
        Me.formForm2.Size = New System.Drawing.Size(108, 22)
        Me.formForm2.Text = "Form2"
        '
        'formBlank
        '
        Me.formBlank.Name = "formBlank"
        Me.formBlank.Size = New System.Drawing.Size(108, 22)
        Me.formBlank.Text = "Blank"
        '
        'formsHome
        '
        Me.formsHome.Name = "formsHome"
        Me.formsHome.Size = New System.Drawing.Size(108, 22)
        Me.formsHome.Text = "Home"
        '
        'menuSettings
        '
        Me.menuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(61, 35)
        Me.menuSettings.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 35)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(859, 494)
        Me.Controls.Add(Me.mainFrame)
        Me.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Window Forms"
        Me.mainFrame.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.PageContainer.ResumeLayout(False)
        Me.PageContainer.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainFrame As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PageContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents menuForms As ToolStripMenuItem
    Friend WithEvents formMain As ToolStripMenuItem
    Friend WithEvents formBlank As ToolStripMenuItem
    Friend WithEvents menuSettings As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents formForm2 As ToolStripMenuItem
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnForm2 As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents formsHome As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
